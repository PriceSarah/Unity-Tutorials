using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisMovementBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private CharacterController controller;

    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement.Normalize();

        //Set the magnitude
        movement *= speed;

        //Move
        controller.Move(movement * Time.deltaTime);

    }
}
