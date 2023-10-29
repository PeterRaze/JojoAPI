# JojoAPI Documentation 

This API Rest was developed using .NET Entity Framework and it provides a basic representation of Characters and Stands of the Japanese manga serie called ***JoJo's Bizarre Adventure***.   
Contact Info: pedromunizbneto@gmail.com  
Version: v1  
All rights reserved.  

This project follows the **Repository Pattern**:

- **Controllers**  
- **Core**
- **Data**
- **Model**  

### **Setup Database** 

**Requirements:**

- PostgreSQL
- Visual Studio 2022

Open the solution and check if the project is working.

First, you need to get your PostgreSQL connection string.

The information needs:

```
Server = localhost;
Database = DATABASE_NAME;
Port = PORT_NUMBER;
User Id = POSTGRE_USER_ID;
Password = POSTGRE_PASSWORD
```
Then, you will open the file **"appsettings.json"** in the project and replace the label **"DefaultConnection"** with your connection string.

### **Code-First Approach**

In the Code-First approach, you focus on the domain of your application and start creating classes for your domain entity rather than design your database first and then create the classes which match your database design.

Now you need to populate your database with the migration already included in the project.

Open the **"Package Manager Console"**.

Run the following command:

- Update-Database



## **API Methods**

### Characters

##### GET

- [/api/characters](#markdown-header-get-apicharacters)
- [/api/characters/{name}](#markdown-header-get-apicharactersname) 
- [/api/characters/{id}](#markdown-header-get-apicharactersid)
- [/api/characters/jojos](#markdown-header-get-apiusersid) 
- [/api/characters/jobros](#markdown-header-get-apiusersid) 
- [/api/characters/villains ](#markdown-header-get-apiusersid) 

##### POST

- [/api/characters](#markdown-header-post-apiusersregister)

##### PUT

- [/api/characters](#markdown-header-put-apiusersid)

##### DELETE

- [/api/characters](#markdown-header-delete-apiusersid)

### Stands

##### GET

- [/api/stands](#markdown-header-get-apileaderboard)
- [/api/stands/{name}](#markdown-header-get-apileaderboardtopn) 
- [/api/stands/{id}](#markdown-header-get-apiusers)

##### POST

- [/api/stands](#markdown-header-post-apiusersregister)

##### PUT

- [/api/stands](#markdown-header-put-apiusersid)

##### DELETE

- [/api/stands](#markdown-header-delete-apiusersid)

## GET /api/characters

**Description**  
Returns a list of all characters.

**Return type**  
array [Character]

**Server Response**
**Example data**  
Content-Type: application/json
```
[
  {
    "id": 1,
    "name": "Dio",
    "surname": "Brando",
    "seasonDebut": 1,
    "stand": {
      "id": 1,
      "name": "The World",
      "ability": "Super Strength, Senses, Speed and Precision. Stop Time",
      "reference": "Holy Diver by Ronnie James Dio; Tarot Card: The World; which represents the beggining of a new world order"
    },
    "role": "Villain"
  },
  {
    "id": 4,
    "name": "Jonathan",
    "surname": "Joestar",
    "seasonDebut": 1,
    "stand": null,
    "role": "Jojo"
  }
]
```

**Responses**  
**200**  
Success array [Character]

## GET /api/characters/{id}

**Description**    
Returns a specific character by its ID.

**Return type**  
[Character]

**Parameters**  
**Path parameters**  
> **ID (required)**  
> Path Parameter -> format: int32


**Server Response**  
**Example data**  
Content-Type: application/json
```

{
  "id": 1,
  "name": "Dio",
  "surname": "Brando",
  "seasonDebut": 1,
  "stand": {
    "id": 1,
    "name": "The World",
    "ability": "Super Strength, Senses, Speed and Precision. Stop Time",
    "reference": "Holy Diver by Ronnie James Dio; Tarot Card: The World; which represents the beggining of a new world order"
  },
  "role": "Villain"
}

```

**Responses**  
**200**  
Success [Character]

**404**  
Not Found

## GET /api/characters/{name}

**Description**  
Returns a specific character by its name.

**Return type**  
[Character]

**Parameters**  
**Path parameters**  
> **Name (required)**  
> Path Parameter -> format: string


**Server Response**
**Example data**  
Content-Type: application/json
```
{
  "id": 1,
  "name": "Dio",
  "surname": "Brando",
  "seasonDebut": 1,
  "stand": {
    "id": 1,
    "name": "The World",
    "ability": "Super Strength, Senses, Speed and Precision. Stop Time",
    "reference": "Holy Diver by Ronnie James Dio; Tarot Card: The World; which represents the beggining of a new world order"
  },
  "role": "Villain"
}
```

**Responses**  
**200**  
Success [Character]

**404**  
Not Found

## GET /api/characters/jojos

**Return type**  
array [Character]

**Description**  
Return the characters who have the role defined as Jojo.

**Server Response**
**Example data**  
Content-Type: application/json
```
[
  {
    "id": 10,
    "name": "Joseph",
    "surname": "Joestar",
    "seasonDebut": 2,
    "stand": {
      "id": 6,
      "name": "Hermit Purple",
      "ability": "Vines creation whose movements can be controlled",
      "reference": "Tarot card: The Hermit; which symbolizes contemplation and instrospection"
    },
    "role": "Jojo"
  },
  {
    "id": 14,
    "name": "Jotaro",
    "surname": "Kujo",
    "seasonDebut": 3,
    "stand": {
      "id": 3,
      "name": "Star Platinum",
      "ability": "Super Strength, Senses, Speed and Precision. Stop Time",
      "reference": "North Star - Platinum Finale by Mike Oldfield; Tarot Card: The Star; which symbolizes optimism, discernment, and hope"
    },
    "role": "Jojo"
  }
]
```

**Responses**  
**200**  
Success array [Character]

## GET /api/characters/jobros

**Return type**  
array [Character]

**Description**  
Return the characters who have the role defined as JoBro.

**Server Response**
**Example data**  
Content-Type: application/json
```
[
  {
      "id": 11,
      "name": "Kakyoin",
      "surname": "Noriaki",
      "seasonDebut": 3,
      "stand": {
        "id": 7,
        "name": "Hierophant Green",
        "ability": "Sliding its coils into a person's body",
        "reference": "Tarot card: The Hierophant; which symbolizes tradition and conformity"
      },
      "role": "JoBro"
    },
    {
      "id": 12,
      "name": "Jean",
      "surname": "Polnareff",
      "seasonDebut": 3,
      "stand": {
        "id": 8,
        "name": "Silver Chariot",
        "ability": "High speed and powerful attack",
        "reference": "Tarot card: The Chariot; which symbolizes invasion and victory"
      },
      "role": "JoBro"
  }
]
```

**Responses**  
**200**  
Success array [Character]

## GET /api/characters/villains

**Return type**  
array [Character]

**Description**  
Return the characters who have the role defined as Villain.

**Server Response**
**Example data**  
Content-Type: application/json
```
[
  {
    "id": 18,
    "name": "Kira",
    "surname": "Yoshikage",
    "seasonDebut": 4,
    "stand": {
      "id": 13,
      "name": "Killer Queen",
      "ability": "Killer Queen's Primary Bomb is to charge any object, inanimate or not, as a bomb simply by touching it",
      "reference": "Killer Queen by Queen"
    },
    "role": "Villain"
  },
  {
    "id": 19,
    "name": "Enrico",
    "surname": "Pucci",
    "seasonDebut": 6,
    "stand": {
      "id": 14,
      "name": "Whitesnake",
      "ability": "Manipulate and preserve people's memories and souls within special DISCs",
      "reference": "Saints and Sinners by Whitesnake"
    },
    "role": "Villain"
  }
]
```

**Responses**  
**200**  
Success array [Character]

## POST /api/characters

**Return type**  
[Character]  

**Description**  
Register a user.

**Parameters**

**Request body**  
> **body [CharacterInDTO](#markdown-header-userdto) (required)**  
> Body Parameter 

**Server Response**
**Example data**  
```
{
  "id": 16,
  "name": "Okuyasu",
  "surname": "Nijimura",
  "seasonDebut": 4,
  "stand": {
    "id": 11,
    "name": "The Hand",
    "ability": "Anything that The Hand's right palm touches when it does a swiping motion with its arm is erased from this universe, be it physical matters or space itself",
    "reference": "The Band"
  },
  "role": "JoBro"
}
```

**Responses**  
**201**  
Created 

## DELETE /api/characters/{id}

**Description**  
Delete a character using its id.

**Parameters**  
**Path parameters**  
> **id (required)**  
> Path Parameter -> format: int32

**Responses**  
**204**  
Success - No Content

**404**  
Not Found

## PUT /api/characters

**Description**  
Update a character.  

**Request body**  
> **body [CharacterUpdateInDTO](#markdown-header-userdto) (required)**  
>  Body Parameter

**Responses**  
**204**  
Success - No Content

**404**  
Not Found

## GET /api/stands

**Description**  
Returns a list of all stands.

**Return type**  
array [Stand]

**Server Response**
**Example data**  
Content-Type: application/json
```
[
  {
    "id": 4,
    "name": "Purple Haze",
    "ability": "Infects any living thing within its range",
    "reference": "Purple Haze by Jimi Hendrix"
  },
  {
    "id": 5,
    "name": "Magician's Red",
    "ability": "Produce and manipulate fire",
    "reference": "Tarot card: The Magician; which represents creation"
  }
]
```

**Responses**  
**200**  
Success array [Stand]

## GET /api/stands/{id}

**Description**    
Returns a specific stand by its ID.

**Return type**  
[Stand]

**Parameters**  
**Path parameters**  
> **ID (required)**  
> Path Parameter -> format: int32

**Server Response**  
**Example data**  
Content-Type: application/json
```

{
  "id": 8,
  "name": "Silver Chariot",
  "ability": "High speed and powerful attack",
  "reference": "Tarot card: The Chariot; which symbolizes invasion and victory"
}

```

**Responses**  
**200**  
Success [Stand]

**404**  
Not Found

## GET /api/stands/{name}

**Description**  
Returns a specific stand by its name.

**Return type**  
[Stand]

**Parameters**  
**Path parameters**  
> **Name (required)**  
> Path Parameter -> format: string

**Server Response**
**Example data**  
Content-Type: application/json
```

{
  "id": 8,
  "name": "Silver Chariot",
  "ability": "High speed and powerful attack",
  "reference": "Tarot card: The Chariot; which symbolizes invasion and victory"
}

```

**Responses**  
**200**  
Success [Stand]

**404**  
Not Found

## POST /api/stands

**Return type**  
[Stand]  

**Description**  
Register a stand.

**Parameters**

**Request body**  
> **body [StandInDTO](#markdown-header-userdto) (required)**  
> Body Parameter 

**Server Response**
**Example data**  
```
{
  "id": 8,
  "name": "Silver Chariot",
  "ability": "High speed and powerful attack",
  "reference": "Tarot card: The Chariot; which symbolizes invasion and victory"
}
```

**Responses**  
**201**  
Created 

## DELETE /api/characters/{id}

**Description**  
Delete a stand using its id.

**Parameters**  
**Path parameters**  
> **id (required)**  
> Path Parameter -> format: int32

**Responses**  
**204**  
Success - No Content

**404**  
Not Found

## PUT /api/characters

**Description**  
Update a stand.  

**Request body**  
> **body [Stand](#markdown-header-userdto) (required)**  
>  Body Parameter

**Responses**  
**204**  
Success - No Content

**404**  
Not Found


## **Models**

### Table of Contents

- [Character](#markdown-header-userdto)
- [ChracterInDTO](#markdown-header-userdto)
- [CharacterUpdateInDTO](#markdown-header-userdto)
- [Role](#markdown-header-userdto)
- [Stand](#markdown-header-userdto)
- [StandInDTO](#markdown-header-userdto)

### **Description**


## Character

> **id**    
> Integer format: int32  

> **name**  
> String  

> **surname**  
> String

> **seasonDebut**    
> Integer format: int32  

> **stand**  
> Stand

> **role**  
> Role

Json Example:

```
{
    "id": 21,
    "name": "Jolyne",
    "surname": "Kujo",
    "seasonDebut": 6,
    "stand": {
      "id": 16,
      "name": "Stone Free",
      "ability": "Unravel body into string, typically beginning with her hands, and freely manipulate it",
      "reference": "Stone Free by Jimi Hendrix"
    },
    "role": "Jojo"
}
```

## CharacterInDTO

> **name**  
> String  

> **surname**  
> String

> **seasonDebut**    
> Integer format: int32  

> **standId**    
> Integer format: int32  

> **role**  
> Role

Json Example:

```
{
  "name": "Dio",
  "surname": "Brando",
  "seasonDebut": 1,
  "standId": 1,
  "role": "Villain"
}
```

## CharacterUpdateInDTO

> **id**    
> Integer format: int32  

> **name**  
> String  

> **surname**  
> String

> **seasonDebut**    
> Integer format: int32  

> **standId**    
> Integer format: int32  

> **role**  
> Role

Json Example:

```
{
  "id": 1
  "name": "Dio",
  "surname": "Brando",
  "seasonDebut": 1,
  "standId": 1,
  "role": "Villain"
}
```

## Role string

> **Enum**    
> [ Jojo, JoBro, Villain]  

## Stand

> **id**    
> Integer format: int32  

> **name**  
> String  

> **ability**  
> String

> **reference**    
> String

## StandInDTO

> **name**  
> String  

> **ability**  
> String

> **reference**    
> String
