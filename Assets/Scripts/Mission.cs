using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mission : MonoBehaviour {

    [SerializeField]
    Text mission1; 

	// Use this for initialization
	void Start () {
        mission1.text = "Objectif : Trouvez le cadavre";

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Perso")
        {
            mission1.text = "Quête accomplie !";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Perso")
        {
            mission1.text = "Nouvel objectif : Interrogez désormais la population pour en savoir plus";
        }
    }
}
