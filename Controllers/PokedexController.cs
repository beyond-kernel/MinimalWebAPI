using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MinimalWebAPI.Model;

namespace MinimalWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokedexController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Pokemon> GetPokemonList()
        {
            try
            {
                var pokemonCollection = new List<Pokemon>(){

                    new Pokemon() {
                      Id =  1,
                      Types = new  List<string>() {
                        "Grass",
                        "Poison"
                      },
                      Name = "Bulbasaur",
                      Legendary =  false,
                      Hp =  45,
                      Attack =  49,
                      Defense =  49,
                      Speed =  45,
                      Generation =  1
                    },
                    new Pokemon() {
                      Id =  5,
                      Types = new  List<string>() {
                        "Fire"
                      },
                      Name =  "Charmander",
                      Legendary =  false,
                      Hp =  39,
                      Attack =  52,
                      Defense =  43,
                      Speed =  65,
                      Generation =  1
                    },
                    new Pokemon() {
                      Id =  10,
                      Types = new  List<string>() {
                        "Water"
                      },
                      Name =  "Squirtle",
                      Legendary =  false,
                      Hp =  44,
                      Attack =  48,
                      Defense =  65,
                      Speed =  43,
                      Generation =  1
                    }
                };

                return pokemonCollection;
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}