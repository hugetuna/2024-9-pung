using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public float ballSpeed=10;
    public float shootRadius;
    private float virticalSpeed;
    public float horizontalSpeed=700;
    // Start is called before the first frame update
    void Start()
    {
        shootRadius = Random.Range(Mathf.PI / 4, 3 * Mathf.PI / 4);
        virticalSpeed = Mathf.Cos(shootRadius) * ballSpeed;
        ballRigidbody2D.AddForce(new Vector2(horizontalSpeed, virticalSpeed), ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void virticalSpeedChange()
    {
        virticalSpeed = -virticalSpeed;
        
    }
    public void horizontalSpeedChange()
    {
        horizontalSpeed = -horizontalSpeed;
        
    }
    
}
