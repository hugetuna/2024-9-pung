using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1GoleScript : MonoBehaviour
{
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            logic.p2AddScore(1);
        }
    }
}
