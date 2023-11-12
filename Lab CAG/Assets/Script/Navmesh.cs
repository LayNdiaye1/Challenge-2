using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Thetarget;
    public NavMeshAgent TheAgent;

    void Start()
    {
        TheAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        TheAgent.destination = Thetarget.transform.position;
    }
}
