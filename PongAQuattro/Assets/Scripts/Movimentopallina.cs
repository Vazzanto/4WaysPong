using System;
using UnityEngine;

public class Movimentopallina : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public int direzioneX = 3;
    public int direzioneY = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody != null)
        {
            rigidbody.AddForce(new Vector2(direzioneX, direzioneY));


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direzioneX = -direzioneX;
        direzioneY = -direzioneY;
        
    }
}