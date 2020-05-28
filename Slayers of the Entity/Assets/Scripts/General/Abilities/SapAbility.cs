using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapAbility : Ability
{
    public int dano = 5;
    public int notBonus = 10;
    public SapAbility(AbilityData abilityData) : base(abilityData)
    {
    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        foreach(Unit u in targets)
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
            unit.BajarDanoExtra(notBonus);
        }
    }
}
