﻿using JojoAPI.Core.Interfaces;
using JojoAPI.Model;
using JojoAPI.Model.DTOs.Incoming;
using Microsoft.AspNetCore.Mvc;

namespace JojoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StandsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public StandsController(IUnitOfWork unitOfWork) 
        { 
            this.unitOfWork = unitOfWork;
        }

        #region GET

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await unitOfWork.Stands.GetAll());
        }

        [HttpGet]
        [Route("GetStandById")]
        public async Task<IActionResult> GetById(int id)
        {
            var stand = await unitOfWork.Stands.GetById(id);

            if (stand == null) return NotFound();
            
            return Ok(stand);   
        }

        [HttpGet]
        [Route("GetStandByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            var stand = await unitOfWork.Stands.GetByName(name);

            if (stand == null) return NotFound();
            
            return Ok(stand);
        }

        #endregion

        #region POST

        [HttpPost]
        [Route("AddStand")]
        public async Task<IActionResult> AddStand(StandInDTO standIn)
        {
            var standExisted = await unitOfWork.Stands.GetByName(standIn.Name);

            if (standExisted != null) return Conflict();

            Stand stand = new Stand()
            {
                Name = standIn.Name,
                Ability = standIn.Ability,
                Reference = standIn.Reference
            };

            await unitOfWork.Stands.Add(stand);
            await unitOfWork.CompleteAsync();
            
            return Ok();
        }

        #endregion

        #region PUT

        [HttpPut]
        [Route("UpdateStand")]
        public async Task<IActionResult> UpdateStand(Stand stand)
        {
            var standInstance = await unitOfWork.Stands.GetById(stand.Id);

            if (standInstance == null) return NotFound();

            await unitOfWork.Stands.Update(stand);
            await unitOfWork.CompleteAsync();
            
            return NoContent();
        }

        #endregion

        #region DELETE

        [HttpDelete]
        [Route("DeleteStand")]
        public async Task<IActionResult> DeleteStandById(int standId)
        {
            var stand = unitOfWork.Stands.GetById(standId);
            
            if (stand == null) return NotFound();
            
            await unitOfWork.Stands.Delete(stand.Result);
            await unitOfWork.CompleteAsync();

            return NoContent();
        }

        #endregion

    }
}
