using System.Security.Authentication.ExtendedProtection;
namespace GameTest;

using PokemonGame;

[TestClass]
public class PokemonTest
{

    Pokemon pok = null!;

    [TestInitialize]
    public void TestInitialize()
    {
        pok = new Pokemon(
            49, 318, 45, 49, 45, 65, 65, 45, 1, false, "Bulbasaur",
            (PokemonType)Enum.Parse(typeof(PokemonType), "grass"),
            (PokemonType)Enum.Parse(typeof(PokemonType), "poison"),
            new float[] { 1, 1, 1, 0.5F, 0.5F, 0.5F, 2, 2, 1, 0.25F, 1, 2, 1, 1, 2, 1, 1, 0.5F }
        );
    }

    [TestMethod]
    public void CreatePokemon()
    {
        Assert.AreEqual("Bulbasaur", pok.Name);
        Assert.AreEqual(49, pok.Attack);
        Assert.AreEqual(PokemonType.grass, pok.Type1);
        Assert.AreEqual(PokemonType.poison, pok.Type2);
    }

    [TestMethod]
    public void ClonePokemon()
    {
        Pokemon clonPok = (Pokemon)pok.Clone();

        Assert.AreEqual("Bulbasaur", clonPok.Name);
        Assert.AreEqual(49, clonPok.Attack);
        Assert.AreEqual(PokemonType.grass, clonPok.Type1);
        Assert.AreEqual(PokemonType.poison, clonPok.Type2);
    }

    [TestMethod]
    public void AttackPokemon()
    {
        Pokemon clonPok = (Pokemon)pok.Clone();
        pok.AttackPokemon(clonPok);

        Assert.AreEqual(45, clonPok.Hp);
        Assert.AreEqual(false, pok.isDead);
    }
}