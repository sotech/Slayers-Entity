using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DataBase : MonoBehaviour
{
   public static DataBase instance;
   public UnitData[] unitsData;
   public AbilityData[] abilitiesData;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        #region Singleton
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this);
        }
        #endregion
    }
   public UnitData GetUnitDataById(int _id)
   {
        for (int i = 0; i < unitsData.Length; i++)
        {
            if(unitsData[i].id == _id)
            {
                return unitsData[i];
            }
        }
        return null;
   }
   public UnitData GetUnitDataByName(string _n)
   {
       for (int i = 0; i < unitsData.Length; i++)
       {
            if (unitsData[i].nombre == _n)
            {
                return unitsData[i];
            }
       }
        return null;
   }
   public AbilityData GetAbilityDataByName(string _n)
   {
        print("Looking for " + _n);
        for (int i = 0; i < abilitiesData.Length; i++)
        {
            if(abilitiesData[i].nombre == _n)
            {
                Debug.Log("Ability found");
                return abilitiesData[i];
            }
        }
        Debug.Log("Ability not found");
        return null;
   }
    
}
