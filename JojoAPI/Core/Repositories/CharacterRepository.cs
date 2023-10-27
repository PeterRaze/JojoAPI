using JojoAPI.Core.Interfaces;
using JojoAPI.Data;
using JojoAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace JojoAPI.Core.Repositories
{
    public class CharacterRepository : GenericRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(ApiDbContext context, ILogger logger) : base(context, logger) { }

        public override async Task<IEnumerable<Character>> GetAll()
        {
            return await dbSet.Include(x => x.Stand).ToListAsync();
        }

        public async Task<Character?> GetByName(string name)
        {
            return await dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<Character?> GetByNameAndSurname(string name, string surname)
        {
            return await dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Name == name && x.Surname == surname);
        }
    }
}
