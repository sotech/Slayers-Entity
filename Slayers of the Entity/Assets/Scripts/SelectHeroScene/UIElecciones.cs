using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElecciones : MonoBehaviour
{
    private static UICard[] cards;
    private void Start()
    {
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("Card");
        cards = new UICard[objetos.Length];
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = objetos[i].GetComponent<UICard>();
        }
    }
    public static void ResetColors()
    {
        foreach (UICard card in cards)
        {
            card.playAnimation = false;
        }

    }
}
