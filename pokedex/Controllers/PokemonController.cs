using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace pokedex.Controllers
{

[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{ 
  private readonly IPokemonService _pokemonService;
  public PokemonController(IPokemonService pokemonService)
{
    _pokemonService = pokemonService;
}


  [HttpGet]
  public async Task<List<PokemonModel>> Get()
  {
    return await _pokemonService.Get();
  }

  [HttpGet("{id}")]
  public async Task<PokemonModel?> GetPokemonById(string id)
  {
    return await _pokemonService.GetPokemonById(id);
  }

  [HttpPost]
  public async Task<List<PokemonModel>> AddPokemon(PokemonModel newPokemon)
  {
    return await _pokemonService.AddPokemon(newPokemon);
  }

  [HttpPut("{id}")]
  public async Task<List<PokemonModel>> UpdatePokemon(string id, PokemonModel updatedPokemon)
  {
    return await _pokemonService.UpdatePokemon(id, updatedPokemon);
  }

  [HttpDelete("{id}")]
  public async Task<List<PokemonModel>> DeletePokemon(string id)
  {
    return await _pokemonService.DeletePokemon(id);
  }
  }
}