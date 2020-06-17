using System;
using UnityEngine;

public class RedCarMove : MonoBehaviour
{
    private Vector3 position;
    private int laneNum = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }
    
    public void leftBtn()
    {
        if (laneNum == 1)
        {
            //move left
            position.x = transform.position.x - 0.23f;
            transform.position = position;
            laneNum = 2;
        }
        else if (laneNum == 2)
        {
            //move right
            position.x = transform.position.x + 0.23f;
            transform.position = position;
            laneNum = 1;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (laneNum == 1)
            {
                //move left
                position.x = transform.position.x - 0.23f;
                transform.position = position;
                laneNum = 2;
            }
            else if (laneNum == 2)
            {
                position.x = transform.position.x + 0.23f;
                transform.position = position;
                laneNum = 1;
            }
        }
    }
}
