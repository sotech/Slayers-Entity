using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteAbility : Ability
{
    public int dano = 50;
    public ExecuteAbility(AbilityData abilityData) : base(abilityData)
    {

    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        foreach (Unit u in targets)
        {
            if (!u.IsInvulnerable())
            {
                if(u.GetPercentageHealth() <= 20f)
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
    }
}
