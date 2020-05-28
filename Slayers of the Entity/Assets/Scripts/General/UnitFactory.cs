using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour
{
    public static UnitFactory instance;
    public void Awake()
    {
        DontDestroyOnLoad(this);
        Debug.Log("Unit factory started");
        #region Singleton
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
        #endregion

    }
    public Unit GenerateUnit(int id)
    {
        //Generar unidad en base a la data de la id
        return new Unit(DataBase.instance.GetUnitDataById(id));
    }
    public Hero GenerateHero(string name)
    {
        //Generar unidad en base a la data de la id
        switch (name)
        {
            case "Barbarian":
                return new Barbarian(DataBase.instance.GetUnitDataByName(name));
            case "Assassin":
                return new Assassin(DataBase.instance.GetUnitDataByName(name));
            case "Sage":
                return new Sage(DataBase.instance.GetUnitDataByName(name));
            default:
                return null;
        }        
    }
}
