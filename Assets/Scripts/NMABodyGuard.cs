using UnityEngine;
using System.Collections;

public class NMABodyGuard : MonoBehaviour {

    public Transform target;
    public NavMeshAgent agent;
    private bool playerInZone;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Perso")
        {
            playerInZone = true;
        }
    }
	// Use this for initialization
	void Start () {
        playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
	if (playerInZone)
        {
            agent.SetDestination(target.position);
        }
	}
}
