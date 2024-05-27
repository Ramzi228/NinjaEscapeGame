using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;


public class BreakPlatform : MonoBehaviour
{
    [SerializeField] private float fallDelay = 2f;
    [SerializeField] private float destroyDelay = 2f;

    private bool falling = false;

    private Animator anim;

    [SerializeField] private Rigidbody2D rb;

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (falling)
        {

            return;
        }

        if (collision.transform.tag == "Player")
        {
            StartCoroutine(StartFall());
            anim = GetComponent<Animator>();
            anim.SetTrigger("breakA");
        }
    }

    

    private IEnumerator StartFall()
    {
        falling = true;
       
        yield return new WaitForSeconds(fallDelay);

        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }
}