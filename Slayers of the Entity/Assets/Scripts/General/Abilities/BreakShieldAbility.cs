using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakShieldAbility : Ability
{
    public BreakShieldAbility(AbilityData abilityData) : base(abilityData)
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
        foreach (Unit u in targets)
        {
            //Romper escudo
            u.RomperEscudo();
        }
    }
}
