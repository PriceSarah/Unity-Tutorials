using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class AvoidBehavior : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;

    public Transform target;
    public float speed = 1.0f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //Find the direction
        Vector3 movement = new Vector3(0, 0, 0);
        if (target != null)
        {
            movement = transform.position - target.position;
            movement.Normalize();
        }

        //Set the magnituse
        movement *= speed;

        //Move
        controller.Move(movement * Time.deltaTime);
    }
}
