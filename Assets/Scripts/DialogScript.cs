using UnityEngine;
using System.Collections;

public class DialogScript : MonoBehaviour {

    public GameObject dialogtext;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trigger")
        {
                    }
    } 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
