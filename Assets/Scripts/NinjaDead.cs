using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinjaDead : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject leftButton;
    [SerializeField] private GameObject rightButton;
    [SerializeField] private GameObject textSek;

    public AudioSource coinAudio, deadAudion;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            losePanel.SetActive(true);
            textSek.SetActive(false);
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            deadAudion.Play();


            Time.timeScale = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinAudio.Play();
        }
    }
}
