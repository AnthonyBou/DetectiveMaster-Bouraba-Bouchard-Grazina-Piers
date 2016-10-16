using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

    [SerializeField]
    Text DialoguePNJ;

    [SerializeField]
    Text DialogueUntel;

    [SerializeField]
    Text DialoguePeur;

    private bool playerInZone;

    // Use this for initialization
    void Start () {
        playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
	        if (Input.GetKeyDown(KeyCode.Space) && playerInZone)
        {
            DialoguePNJ.text = "La victime doit être Michelle, elle tenait une grande fête la nuit dernière";
            DialogueUntel.text = "Je suis rentré tôt, mais ce matin j'ai vu quelqu'un sortir enragé de chez Michelle, Gabriel il me semble !";
            DialoguePeur.text = "Non, je n'ai rien fait, laissez-moi J'AI RIEN FAIT JE VOUS DIS !!!";
        }

       if (Input.GetKeyUp(KeyCode.Space) && playerInZone == false)
        {
            DialoguePNJ.text = "";
            DialogueUntel.text = "";
            DialoguePeur.text = "";
        }
	}
    void OnTriggerEnter(Collider other)
    {
           if (other.name == "Perso" )
        {
            playerInZone = true;
              
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Perso")
        {
            playerInZone = false;
        }
    }
    
    
    
}
