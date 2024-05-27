using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject shopCanvas;
    public GameObject settingsCanvas;
    public GameObject menuCanvas;
    public GameObject transitionCanvas;
    [SerializeField] private GameObject losePanel;
    [SerializeField] Animator transitionAnim;





    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void SettingsIn()
    {
        StartCoroutine(TransitionToSettings());
    }

    IEnumerator TransitionToSettings()
    {
        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        settingsCanvas.SetActive(true);
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        
    }

    public void SettingsExit()
    {
        StartCoroutine(TransitionExitSettings());
    }

    IEnumerator TransitionExitSettings()
    {
        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        settingsCanvas.SetActive(false);
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        
    }

    public void ShopIn()
    {
        StartCoroutine(TransitionToShop());
    }

    IEnumerator TransitionToShop() 
    {
        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        shopCanvas.SetActive(true);
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        
    }
    
    public void ShopExit()
    {
        StartCoroutine(TransitionExitShop());
    }

    IEnumerator TransitionExitShop()
    {
        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        shopCanvas.SetActive(false);
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        
    }

    


    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void ExitToMenu()
    {
        
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;


    }

    





}
