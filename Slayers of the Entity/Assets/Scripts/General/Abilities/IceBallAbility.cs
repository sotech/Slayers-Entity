using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBallAbility : Ability
{
    public int dano = 30;
    public int escudo = 5;
    public IceBallAbility(AbilityData abilityData) : base(abilityData)
    {

    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        foreach (Unit u in targets)
        {
            if (!u.IsInvulnerable())
            {
                return true;
            }
        }
        return false;
    }

    public override void Use(Unit caster, List<Unit> targets)
    {
        int danoTotal = dano + caster.DanoExtra();
        foreach (Unit u in targets)
        {
            u.Danar(danoTotal);
        }
        caster.GanarEscudo(escudo);
    }
}
