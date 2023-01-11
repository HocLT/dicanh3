using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;

    Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        myBody.velocity = new Vector2(enemySpeed, 0f);
    }

    private void MoveAndFlip()
    {
        
        
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myBody.velocity.x)), 1f);
        enemySpeed *= -1f;
    }
}
