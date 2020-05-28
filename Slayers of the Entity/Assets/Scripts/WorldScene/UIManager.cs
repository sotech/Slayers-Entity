using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //Llenar los campos de la informacion
    [Header("Principal Data")]
    public Image avatar;
    public Text heroName;
    public Text healthtxt;
    public Text healthMaxtxt;
    public Text leveltxt;
    public Text xptxt;
    public Text xpMaxtxt;
    public Text goldtxt;
    [Header("Abilities")]
    public Image ability_1;
    public Image ability_2;
    public Image ability_3;
    public Image ability_4;
    private void Start()
    {
        avatar.sprite = GameManager.instance.hero.GetAvatar();
        heroName.text = GameManager.instance.hero.GetName();
        healthtxt.text = GameManager.instance.hero.GetCurrentHealth().ToString();
        healthMaxtxt.text = GameManager.instance.hero.GetMaxHealth().ToString();
        leveltxt.text = GameManager.instance.hero.level.ToString();
        xptxt.text = GameManager.instance.hero.xp.ToString();
        xpMaxtxt.text = GameManager.instance.hero.xpToNextLevel.ToString();
        goldtxt.text = GameManager.instance.hero.gold.ToString();
        ability_1.sprite = GameManager.instance.hero.GetAbilities()[0].icon;
        ability_2.sprite = GameManager.instance.hero.GetAbilities()[1].icon;
        ability_3.sprite = GameManager.instance.hero.GetAbilities()[2].icon;
        ability_4.sprite = GameManager.instance.hero.GetAbilities()[3].icon;
    }

    private void Update()
    {
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        healthtxt.text = GameManager.instance.hero.GetCurrentHealth().ToString();
        healthMaxtxt.text = GameManager.instance.hero.GetMaxHealth().ToString(); 
        leveltxt.text = GameManager.instance.hero.level.ToString();
        xptxt.text = GameManager.instance.hero.xp.ToString();
        xpMaxtxt.text = GameManager.instance.hero.xpToNextLevel.ToString();
    }
}
