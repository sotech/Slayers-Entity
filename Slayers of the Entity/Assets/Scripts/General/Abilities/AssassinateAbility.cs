using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssassinateAbility : Ability
{
    public int dano = 100;
    public int bonus = 10;
    public AssassinateAbility(AbilityData abilityData) : base(abilityData)
    {
    }

    public override bool PreCondition(Unit caster, List<Unit> targets)
    {
        foreach (Unit unit in targets)
        {
            if(unit.GetPercentageHealth() <= 10)
            {
                return true;
            }
        }
        return false;
    }

    public override void Use(Unit caster, List<Unit> targets)
    {
        int danoTotal = dano + caster.DanoExtra();
        bool afectados = false;
        foreach (Unit unit in targets)
        {
            unit.Danar(danoTotal);
            afectados = true;
        }
        if (afectados)
        {
            caster.AumentarDanoExtra(bonus);
        }
    }
}
