using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoAccel : MonoBehaviour
{
    public Transform player;
    public float catchUpDistance = 5f;  // Adjust the distance at which AI starts catching up
    private NavMeshAgent aiAgent;

    void Start()
    {
        // Assuming the NavMeshAgent is on the same GameObject as this script
        aiAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Check if the player is ahead of the AI car
        if (IsPlayerAhead())
        {
            // Adjust the destination to catch up with the player
            CatchUpWithPlayer();
        }
    }

    bool IsPlayerAhead()
    {
        // Check the distance between the player and the AI car
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);
        return distanceToPlayer > catchUpDistance;
    }

    void CatchUpWithPlayer()
    {
        // Set the AI's destination to the player's position
        aiAgent.SetDestination(player.position);
    }
}
