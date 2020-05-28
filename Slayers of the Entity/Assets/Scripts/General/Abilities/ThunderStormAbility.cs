using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderStormAbility : Ability
{
    public int dano = 20;
    public ThunderStormAbility(AbilityData abilityData) : base(abilityData)
    {
    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        return true;
    }

    
    public override void Use(Unit caster, List<Unit> targets)
    {
        int danoTotal = dano + caster.DanoExtra();
        foreach(Unit u in targets)
        {
            u.Danar(danoTotal);
        }
    }
}
