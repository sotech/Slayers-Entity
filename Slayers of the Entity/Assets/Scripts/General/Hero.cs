using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Unit
{
    public int xp;
    public int xpToNextLevel = 100;
    public int level = 1;
    public int gold;
    public Hero(UnitData hd) : base(hd)
    {

    }
}
