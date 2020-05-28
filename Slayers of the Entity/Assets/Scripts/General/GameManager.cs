using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
public enum Heroes
{
    Barbarian = 0,
    Sage = 1,
    Assassin = 2
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Hero hero;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        Debug.Log("Creating Game Manager");
        if(instance == null)
        {
            instance = this;
        }else if(instance != this){
            Destroy(this);
        }        
        

    }

    private void Start()
    {
        //GenerateRandomHero();        
    }

    public void CreateHero(int heroid)
    {
        string heroChosen = EnumHeroToString((Heroes)heroid);
        
        hero = UnitFactory.instance.GenerateHero(heroChosen);
    }

    public void GenerateRandomHero()
    {
        //Random Heroe        
        string[] heroesarray = { "Barbarian", "Assassin", "Sage" };
        string heroChosen = heroesarray[Random.Range(0, 3)];
        print($"Hero chosen {heroChosen}");
        hero = UnitFactory.instance.GenerateHero(heroChosen);
    }

    public string EnumHeroToString(Heroes h)
    {
        switch (h)
        {
            case Heroes.Barbarian:
                return "Barbarian";
            case Heroes.Sage:
                return "Sage";
            case Heroes.Assassin:
                return "Assassin";
            default:
                return null;
        }
    }
}
