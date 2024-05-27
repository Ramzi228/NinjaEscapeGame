using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LanguageSettings : MonoBehaviour
{
    public int language;

    // Start is called before the first frame update
    void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RussianLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Menu");
    }

    public void EnglishLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Menu");
    }

    public void TurkleyLanguage()
    {
        language = 2;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Menu");
    }







}

