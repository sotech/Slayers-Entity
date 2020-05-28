using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Ability Data",menuName ="Unit/New Ability Data")]
public class AbilityData : ScriptableObject
{
    public string nombre;
    public int id;
    public Sprite icon;
    public int speed;
    public Attribute attribute;
}
public enum Attribute
{
    EARTH,
    FIRE,
    WIND,
    WATER,
    NORMAL
}
