using System.Security.Authentication.ExtendedProtection;
namespace GameTest;

using PokemonGame;

[TestClass]
public class PokemonCollectionTest
{
    [TestMethod]
    public void PokemonColectionPushTest() {
        _ = new PokemonCollection("../../../../data/pokemon.csv");
    }

    [TestMethod]
    public void PokemonColectionFindTest() {
        PokemonCollection collection = new("../../../../data/pokemon.csv");
        var foundPokemon = collection.FindByName("Venusaur");
        Assert.AreEqual(625, foundPokemon.BaseTotal);
        Assert.AreEqual(PokemonType.grass, foundPokemon.Type1);
        Assert.AreEqual(PokemonType.poison, foundPokemon.Type2);

        foundPokemon = collection.FindByName("Growlithe");
        Assert.AreEqual(350, foundPokemon.BaseTotal);
        Assert.AreEqual(PokemonType.fire, foundPokemon.Type1);
    }

}