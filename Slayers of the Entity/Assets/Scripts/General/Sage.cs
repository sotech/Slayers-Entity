using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sage : Hero
{
    public Sage(UnitData hd) : base(hd)
    {
        //AddAbility(AbilityFactory.instance.GenerateAbility("Ice Ball"));
        IceBallAbility iceball = new IceBallAbility(DataBase.instance.GetAbilityDataByName("Ice Ball"));
        FireBallAbility fireball = new FireBallAbility(DataBase.instance.GetAbilityDataByName("Fire Ball"));
        RainStormAbility rainstorm = new RainStormAbility(DataBase.instance.GetAbilityDataByName("Rain Storm"));
        ThunderStormAbility thunderstorm = new ThunderStormAbility(DataBase.instance.GetAbilityDataByName("Thunder Storm"));
        AddAbility(iceball);
        AddAbility(fireball);
        AddAbility(rainstorm);
        AddAbility(thunderstorm);
        ListarAbilidades();
    }
    public override void Signature()
    {
        Debug.Log("Ice up");
    }
}
