namespace PokemonGame;

public class Pokemon : ICloneable
{
    public Pokemon(
        float attack,
        int base_total,
        int capture_rate,
        float defence,
        float hp,
        int sp_attack,
        int sp_defence,
        int speed,
        int generation,
        bool is_legend,
        string name,
        PokemonType type1,
        PokemonType? type2,
        float[] againstTypeTable)
    {
        throw new NotImplementedException();
    }

    public object Clone()
    {
        throw new NotImplementedException();
    }

    public bool isDead
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public void AttackPokemon(Pokemon target)
    {
        throw new NotImplementedException();
    }
}