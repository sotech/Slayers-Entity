using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability
{
    public string name;
    public int speed;
    public Attribute attribute;
    public int id;
    public Sprite icon;
    public Ability(AbilityData abilityData)
    {
        name = abilityData.name;
        speed = abilityData.speed;
        attribute = abilityData.attribute;
        id = abilityData.id;
        icon = abilityData.icon;
    }

    public abstract bool PreCondition(Unit caster, List<Unit> targets);
    public abstract void Use(Unit caster, List<Unit> targets);
}
