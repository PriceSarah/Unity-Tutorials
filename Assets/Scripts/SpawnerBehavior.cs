using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform behaviorTarget;

    public float timeInterval = 5.0f;
    public float timeRemaining = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Decrement the time remaining
        timeRemaining -= Time.deltaTime;
        //If no time is remaining
        if (timeRemaining <= 0)
        {
            //Reset timer
            timeRemaining = timeInterval;
            //Spawn the instance
            spawnInstance();
        }
    }

    void spawnInstance()
    {
        //Spawn an instnace of the objectToSpawn
        GameObject spawnedInstance = Instantiate(objectToSpawn, transform.position, transform.rotation);
        //Set the pursueBehaviors target to the behaviorTarget
        PursueBehavior pursueBehavior = spawnedInstance.GetComponent<PursueBehavior>();
        if (pursueBehavior != null)
        {
            pursueBehavior.target = behaviorTarget;
        }
        //Set the AvoidBehaviors target to the behaviorTarget
        AvoidBehavior avoidBehavior = spawnedInstance.GetComponent<AvoidBehavior>();
        if (avoidBehavior != null)
        {
            avoidBehavior.target = behaviorTarget;
        }
    }
}
