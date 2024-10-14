using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serverScript : MonoBehaviour
{
    public GameObject ball;
    public bool direction = false;//0 for p1, 1 for p2
    private GameObject currentBall;
    // Start is called before the first frame update
    void Start()
    {
        serverBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void serverBall()
    {
        // 檢查是否有現有的球在場景中，如果有則銷毀它
        if (currentBall != null)
        {
            Debug.Log("ball gone");
            Destroy(currentBall);
        }

        // 檢查ball是否已被分配資源
        if (ball != null)
        {
            // 生成新球並保存對它的引用
            currentBall = Instantiate(ball, transform.position, transform.rotation);
            direction = !direction;
            if (direction == false)
            {
                currentBall.GetComponent<ballScript>().horizontalSpeed = 700;
            }
            else
            {
                currentBall.GetComponent<ballScript>().horizontalSpeed = -700;
            }
            
        }
        else
        {
            Debug.LogWarning("ball prefab is not assigned in the inspector.");
        }
    }
}
