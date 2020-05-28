using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Unit Data",menuName ="Unit/New Unit Data" +
    "")]
public class UnitData : ScriptableObject
{
    public string nombre;
    public int id;
    public int maxHealth;
    public Sprite avatar;
}
