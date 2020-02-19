using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTest.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strength = 67},
            new Pokemon() {Name = "Bulbasaur", Strength = 200},
            new Pokemon() {Name = "Eva-Lena", Strength = 9001}
        };

        Random random = new Random();



        [HttpGet]
        public ActionResult MyPerfectGet()
        {
            // Pokemon p = new Pokemon();
            // p.Name = "Ekans";
            // p.Strength = 67;

            var p = pokemons[random.Next(pokemons.Count)];

            return Ok(p);
        }

        [HttpPost]
        public ActionResult AddNewPokemon(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine($"Added {newPokemon.Name}");

            return Created("", newPokemon);
        }


    }
}
