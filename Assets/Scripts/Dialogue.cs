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

    [SerializeField]
    Text DialogueTemoin;

    [SerializeField]
    Text DialogueSuspect;

    [SerializeField]
    Text DialogueCoupable;

    private bool playerInZone;

    // Use this for initialization
    void Start () {
        playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
	        if (Input.GetKeyDown(KeyCode.Space) && playerInZone)
        {
            DialoguePNJ.text = "Thomas : La victime doit être Michelle, elle tenait une grande fête la nuit dernière";
            DialogueUntel.text = "Philippe : Je suis rentré tôt, mais ce matin j'ai vu quelqu'un sortir enragé de chez Michelle, Gabriel il me semble !";
            DialoguePeur.text = "Nasser : Non, je n'ai rien fait, laissez-moi J'AI RIEN FAIT JE VOUS DIS !!!";
            DialogueTemoin.text = "Marina : Elle habitait juste là, à côté de moi. Selon moi, il n'y a que deux personnes qui auraient pu la tuer, Gabriel et Nicolas.";
            DialogueSuspect.text = "Gabriel : Oui c'est moi Gabriel. Mais je ne l'ai pas tué c'est vrai que nous nous sommes disputés mais je n'aurais jamais pu la tuer, elle représentait trop pour moi ! Nicolas était jaloux, et il est introuvable !";
            DialogueCoupable.text = "Nicolas : Vous me soupçonnez donc si rapidement et vous avez raison de le faire.... Cherchez bien et vous allez savoir qui est le coupable, moi ou quelqu'un d'autre";
        }

       if (Input.GetKeyUp(KeyCode.Space) && playerInZone == false)
        {
            DialoguePNJ.text = "";
            DialogueUntel.text = "";
            DialoguePeur.text = "";
            DialogueTemoin.text = "";
            DialogueSuspect.text = "";
            DialogueCoupable.text = "";
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
