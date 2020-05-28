using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RushAbility : Ability
{
    public int dano = 30;
    public int curacion = 10;
    public RushAbility(AbilityData abilityData) : base(abilityData)
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
            //Danar jugador
            u.Danar(danoTotal);            
        }
        //Ganar vida
        caster.Curar(curacion);
    }
}
