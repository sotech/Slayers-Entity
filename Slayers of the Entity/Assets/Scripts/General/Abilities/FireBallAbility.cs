using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallAbility : Ability
{
    public int dano = 40;
    public FireBallAbility(AbilityData abilityData) : base(abilityData)
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
        foreach(Unit u in targets)
        {
            if(u.GetCurrentHealth() <= 30)
            {
                u.Danar(Mathf.RoundToInt(danoTotal * 1.10f));
            }
            else
            {
                u.Danar(danoTotal);
            }
            
        }
    }
}
