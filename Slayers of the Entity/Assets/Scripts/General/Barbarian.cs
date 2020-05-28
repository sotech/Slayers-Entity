using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : Hero
{
    public Barbarian(UnitData hd) : base(hd)
    {
        SlashAbility slash = new SlashAbility(DataBase.instance.GetAbilityDataByName("Slash"));
        ExecuteAbility execute = new ExecuteAbility(DataBase.instance.GetAbilityDataByName("Execute"));
        BreakShieldAbility breakShield = new BreakShieldAbility(DataBase.instance.GetAbilityDataByName("Break Shield"));
        RushAbility rush = new RushAbility(DataBase.instance.GetAbilityDataByName("Rush"));
        AddAbility(slash);
        AddAbility(execute);
        AddAbility(breakShield);
        AddAbility(rush);
        ListarAbilidades();
    }
       
    public override void Signature()
    {
        Debug.Log("Axe wants blood");
    }
}
