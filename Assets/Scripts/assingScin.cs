using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignSkin : MonoBehaviour
{
    public Sprite ninjaFirst; 
    public Sprite whiteNinja;
    public Sprite viking; 
    public Sprite robot;
    public Sprite demon;
    public Sprite zombi;

    public GameObject Ball;
    void Start()
    {
        if (PlayerPrefs.GetInt("skinNum") == 1)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = whiteNinja;
        }
        else if (PlayerPrefs.GetInt("skinNum") == 2)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = viking;
        }
        else if (PlayerPrefs.GetInt("skinNum") == 3)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = robot;
        }
        else if (PlayerPrefs.GetInt("skinNum") == 4)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = demon;
        }
        else if (PlayerPrefs.GetInt("skinNum") == 5)
        {
            Ball.GetComponent<SpriteRenderer>().sprite = zombi;
        }
        else
        {
            Ball.GetComponent<SpriteRenderer>().sprite = ninjaFirst;
        }
    }

}

