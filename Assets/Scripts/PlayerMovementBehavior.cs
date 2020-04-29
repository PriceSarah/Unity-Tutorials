using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            //Up
            movement = new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Left
            movement = new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Down
            movement = new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Right
            movement = new Vector3(1, 0, 0);
        }
        movement.Normalize();

        //Set the magnitude
        movement *= speed;

        //Move
        controller.Move(movement * Time.deltaTime);
        
    }
}
