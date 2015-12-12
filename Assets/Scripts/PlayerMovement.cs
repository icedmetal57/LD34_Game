﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;

    private Rigidbody2D rigidBody;

    private SpriteRenderer spriteRenderer;

    public Sprite sprite1;
    public Sprite sprite2;
    private bool spriteChanged = false;

    private CircleCollider2D circCollider;

	// Use this for initialization
	void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        circCollider = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update()
    {
        float dir = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(dir * speed, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!spriteChanged)
            {
                spriteRenderer.sprite = sprite2;
                circCollider.radius = 0.625f;
                spriteChanged = true;
            }
            else
            {
                spriteRenderer.sprite = sprite1;
                circCollider.radius = 0.5f;
                spriteChanged = false;                
            }
        }
	}
}
