using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2Script : MonoBehaviour
{
    public int moveSpeed = 15;
    public GameObject ball;
    private Vector2 moveVector;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moveVector != Vector2.zero)
        {
            if(transform.position.y > 7 && moveVector.y > 0)
            {
                transform.position = transform.position;
            }
            else if(transform.position.y < -7 && moveVector.y < 0)
            {
                transform.position = transform.position;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, moveVector.y, 0) * moveSpeed * Time.deltaTime;
            }
        }
    }
    //chach vector from input
    public void Move(InputAction.CallbackContext ctx)
    {
        moveVector = ctx.ReadValue<Vector2>();
        print(moveVector);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            ball.GetComponent<ballScript>().horizontalSpeedChange();
        }
    }
}

