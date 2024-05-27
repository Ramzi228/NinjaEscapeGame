using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaMove : MonoBehaviour
{
    
    [SerializeField] private float acceleration;
    [SerializeField] private float damping;
    [SerializeField] private float speed;

    

    
    private float targetHorSpeed;
    private float currentHorSpeed;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        currentHorSpeed = Mathf.MoveTowards(currentHorSpeed, targetHorSpeed, acceleration * Time.deltaTime);

        float newXPosition = transform.position.x + currentHorSpeed * Time.deltaTime;
        newXPosition = Mathf.Clamp(newXPosition, -1183f, 1142f); // ограничение движения по координате x

        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        
    }

    public void OnLeftButtonDown()
    {
        targetHorSpeed = -speed;
        
    }

    public void OnRightButtonDown()
    {
        targetHorSpeed = speed;
        
    }

    public void OnButtonUp()
    {
        targetHorSpeed = 0;
    }
}


