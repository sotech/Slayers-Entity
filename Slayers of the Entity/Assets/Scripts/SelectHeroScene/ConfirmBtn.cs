using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ConfirmBtn : MonoBehaviour
{
    //Habilitar el boton solo cuando alguna carta haya sido elegida
    public Button confirmBtn;
    UICard[] cards;
    int heroID;
    //Funcion para que al clickear, llame al GameData, genere la clase correspondiente, reproduzca la animacion y cambie la escena
    public Animator animator;
    public void Start()
    {
        //Button
        confirmBtn.interactable = false;
        //Evento
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("Card");
        cards = new UICard[objetos.Length];
        for (int i = 0; i < objetos.Length; i++)
        {
            cards[i] = objetos[i].GetComponent<UICard>();
            cards[i].cardSelectedEvent += OnCardSelected;
        }
        //Animator
        animator = GameObject.Find("PanelSeleccion").GetComponent<Animator>();
    }
    public void Confirm()
    {
        //Generar clase en GameData
        GameManager.instance.CreateHero(heroID);
        //Reproducir animacion
        StartCoroutine(PlayAnimation());
        //Cambiar escena
        SceneManager.LoadScene("WorldScene");
    }

    IEnumerator PlayAnimation()
    {
        animator.SetTrigger("PlayFadeOutHero");
        yield return new WaitForSeconds(3f);
    }
    #region Control del boton
    public void OnCardSelected(int hid, int cid)
    {
        //Desuscribir
        for (int i = 0; i < cards.Length; i++)
        {
            if(cards[i].cardID == cid)
            {
                cards[i].cardSelectedEvent -= OnCardSelected;
                break;
            }
        }
        //Habilitar el boton
        confirmBtn.interactable = true;
        //Guardar id del heroe
        heroID = hid;
        //Resuscribimos
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i].cardID == cid)
            {
                cards[i].cardSelectedEvent += OnCardSelected;
                break;
            }
        }
    }
    #endregion

}
