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
        // �ˬd�O�_���{�����y�b�������A�p�G���h�P����
        if (currentBall != null)
        {
            Debug.Log("ball gone");
            Destroy(currentBall);
        }

        // �ˬdball�O�_�w�Q���t�귽
        if (ball != null)
        {
            // �ͦ��s�y�ëO�s�復���ޥ�
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
