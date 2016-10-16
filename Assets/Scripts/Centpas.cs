using UnityEngine;
using System.Collections;

public class Centpas : MonoBehaviour {

    public Transform target;
    public Transform target2;
    public NavMeshAgent agent;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(target.position);
        agent.SetDestination(target2.position);
	}
}
