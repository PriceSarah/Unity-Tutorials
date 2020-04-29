using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShootBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position
            Vector3 mousePosition = Input.mousePosition;
            //Get the ray from the camera to the mouse
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
            //Create a plane at the players position
            Plane playerPlane = new Plane(Vector3.up, transform.position);
            //Find where the ray intersects the plane
            float rayDistance = 0.0f;
            playerPlane.Raycast(mouseRay, out rayDistance);
            //Get the point on the ray at the distance to the plane
            Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

            //Find the direction from the player to the target
            Vector3 fireDirection = targetPoint - transform.position;
            fireDirection.Normalize();
            //Create a ray from the players position in the fireDirection
            Ray fireRay = new Ray(transform.position, fireDirection);

            //Cast the fireRay
            RaycastHit hitObjectInfo;
            if (Physics.Raycast(fireRay, out hitObjectInfo))
            {
                //Destroy the hitObject
                Destroy(hitObjectInfo.collider.gameObject);
            }

            Debug.DrawRay(transform.position, fireDirection, Color.red);
        }
    }
}
