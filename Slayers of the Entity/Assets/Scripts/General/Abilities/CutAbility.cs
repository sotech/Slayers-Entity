using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutAbility : Ability
{
    public int dano = 15;
    public int bonus = 5;
    public CutAbility(AbilityData abilityData) : base(abilityData)
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
        foreach (Unit unit in targets)
        {
            unit.Danar(danoTotal);
        }
        caster.AumentarDanoExtra(bonus);
    }   
}
