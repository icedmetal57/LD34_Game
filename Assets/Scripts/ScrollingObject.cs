﻿using UnityEngine;
using System.Collections;

public class ScrollingObject : MonoBehaviour
{
    public float scrollSpeed;

    private Rigidbody2D rigidBody;
    
    public Effect effect;
    
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(0, scrollSpeed) * Time.fixedDeltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Collision(other.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Collision(other.gameObject);
    }

    private void Collision(GameObject otherObj)
    {
        if (otherObj.tag == "Player" && gameObject.tag != "Indestructible")
        {
            if (effect != null)
                effect.ApplyEffect(otherObj);
            Destroy(gameObject);
        }
        if (otherObj.tag == "LevelEnd" || otherObj.tag == "Indestructible")
        {
            Destroy(gameObject);
        }
    }

}
