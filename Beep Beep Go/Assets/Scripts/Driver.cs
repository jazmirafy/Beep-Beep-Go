using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = .7f;
    [SerializeField] float moveSpeed = 0.05f;

    void Start()
    {
        
    }
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") *steerSpeed; //get the  horizontaldirection the player is going and multiply it by steer speed
        float moveAmount  = Input.GetAxis("Vertical") * moveSpeed; //get the verticle direction the player is going and multiply that by the move speed
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount , 0);
    }
}
