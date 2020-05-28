using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Unit
{    
    //Propiedades
    protected string name;
    protected int maxHealth;
    protected int currentHealth;
    protected int shieldAmount;
    protected List<Ability> abilities;
    protected Sprite avatar;
    protected int danoExtra;
    //Estados
    protected bool isInvulnerable;
    protected bool isDead;
    public Unit(UnitData unitData)
    {
        name = unitData.nombre;
        maxHealth = unitData.maxHealth;
        currentHealth = maxHealth;
        abilities = new List<Ability>();
        avatar = unitData.avatar;
    }

    public string GetName()
    {
        return this.name;
    }
    public void AddAbility(Ability a)
    {
        abilities.Add(a);
    }
    public virtual void Signature()
    {
        Debug.Log("Signature Quote used");
    }

    public float GetPercentageHealth()
    {
        return this.currentHealth * 100 / maxHealth;
    }

    public void Danar(int amount)
    {
        this.currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
        }
    }
    public void Curar(int amount)
    {
        this.currentHealth += amount;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void RomperEscudo()
    {
        this.shieldAmount = 0;
    }

    public void GanarEscudo(int amount)
    {
        this.shieldAmount += amount;
    }

    public void ListarAbilidades()
    {
        foreach (Ability a in abilities)
        {
            Debug.Log(a.name);
        }
    }

    public int DanoExtra()
    {
        return this.danoExtra;
    }

    public bool IsInvulnerable()
    {
        return this.isInvulnerable;
    }

    public int GetCurrentHealth()
    {
        return this.currentHealth;
    }
    
    public void AumentarDanoExtra(int amount)
    {
        this.danoExtra += amount;
    }

    public void BajarDanoExtra(int amount)
    {
        this.danoExtra -= amount;
    }

    public List<Ability> GetAbilities()
    {
        return this.abilities;
    }

    public Sprite GetAvatar()
    {
        return this.avatar;
    }

    public int GetMaxHealth()
    {
        return this.maxHealth;
    }
}
