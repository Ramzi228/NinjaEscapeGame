using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            
            CoinText.Coin += 10;
            PlayerPrefs.SetInt("Coins", CoinText.Coin);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }


    
}
