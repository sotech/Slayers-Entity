using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonBladeAbility : Ability
{
    public int bonus = 20;
    public PoisonBladeAbility(AbilityData abilityData) : base(abilityData)
    {
    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        return true;
    }
    public override void Use(Unit caster, List<Unit> targets)
    {
        caster.AumentarDanoExtra(20);
    }
}
