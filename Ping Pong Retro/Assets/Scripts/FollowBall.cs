using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform Ball;
    public float speed;
    

    // Update is called once per frame
    void Update()
    {
        if (Ball.GetComponent<BallBehaviour>().gameStarted)
        {
            if (transform.position.y < Ball.position.y)
            {
                transform.position = new Vector3(transform.position.x,transform.position.y + speed, transform.position.z);
            }else if (transform.position.y > Ball.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            }

        }
    }
}
