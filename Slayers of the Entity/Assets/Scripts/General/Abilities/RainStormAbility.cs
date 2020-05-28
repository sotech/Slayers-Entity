using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainStormAbility : Ability
{
    public int cantidad = 20;
    public RainStormAbility(AbilityData abilityData) : base(abilityData)
    {
    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        return true;
    }

    public override void Use(Unit caster, List<Unit> targets)
    {
        if(caster.GetPercentageHealth() <= 20)
        {
            caster.Curar(Mathf.RoundToInt(cantidad * 1.2f));
        }
        else
        {
            caster.Curar(cantidad);
        }
    }
}
