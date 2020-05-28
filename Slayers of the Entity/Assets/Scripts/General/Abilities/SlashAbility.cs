using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashAbility : Ability
{
    public int dano = 20;
    public SlashAbility(AbilityData abilityData) : base(abilityData)
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
    }


}
