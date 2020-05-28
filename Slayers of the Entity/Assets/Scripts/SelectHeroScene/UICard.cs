using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using System;
public class UICard : MonoBehaviour, IPointerClickHandler
{
    public int heroID;
    public int cardID;
    public string heroName;
    private Image image;
    private Color originalColor;
    public bool playAnimation;
    public delegate void cardSelectedDelegate(int hid, int cid);
    public event cardSelectedDelegate cardSelectedEvent;
    private void Start()
    {
        image = GetComponent<Image>();
        originalColor = image.color;
    }
    //Al clickear, se deberia guardar en el script principal el ID del heroe, para su posterior creacion
    public void OnPointerClick(PointerEventData eventData)
    {
        UIElecciones.ResetColors();
        if (cardSelectedEvent != null)
        {
            cardSelectedEvent(heroID, cardID);
        }        
        playAnimation = true;
    }
    void Update()
    {
        if (playAnimation)
        {
            image.color = Color.Lerp(originalColor, Color.gray, Mathf.PingPong(Time.time,1));
        }
        else
        {
            image.color = originalColor;
        }
    }
    
}
