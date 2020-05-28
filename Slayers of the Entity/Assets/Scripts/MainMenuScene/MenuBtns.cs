using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtns : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GameObject.Find("PanelMenu").GetComponent<Animator>();
    }
    public void StartGame()
    {
        StartCoroutine(StartGameC());
        
    }

    public void LoadGame()
    {

    }

    public void OptionMenu()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator StartGameC()
    {
        animator.SetTrigger("PlayFadeOutMenu");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("SelectHeroScene");
    }
}
