using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBoostingPlatform : MonoBehaviour
{
    [SerializeField] private float _force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Get the player's rigidbody
            var rb = collision.rigidbody;

            // Check if the player's velocity is zero
            if (rb.velocity.magnitude == 0f)
            {

                // Apply the force to the player
                rb.AddForce(Vector2.right * _force, ForceMode2D.Impulse);
            }
        }
    }
}
