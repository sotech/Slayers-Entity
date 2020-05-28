using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassin : Hero
{
    public Assassin(UnitData ud) : base(ud)
    {
        CutAbility cut = new CutAbility(DataBase.instance.GetAbilityDataByName("Cut"));
        AssassinateAbility assassinate = new AssassinateAbility(DataBase.instance.GetAbilityDataByName("Assassinate"));
        SapAbility sap = new SapAbility(DataBase.instance.GetAbilityDataByName("Sap"));
        PoisonBladeAbility poison = new PoisonBladeAbility(DataBase.instance.GetAbilityDataByName("Poison Blade"));
        AddAbility(cut);
        AddAbility(assassinate);
        AddAbility(sap);
        AddAbility(poison);
        ListarAbilidades();
    }

    public override void Signature()
    {
        Debug.Log("My poison is ready");
    }
}
