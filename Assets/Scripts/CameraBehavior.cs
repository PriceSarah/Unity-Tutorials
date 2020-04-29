using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform target;

    private Vector3 boom;

    // Start is called before the first frame update
    void Start()
    {
        boom = this.transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + boom;
    }
}
