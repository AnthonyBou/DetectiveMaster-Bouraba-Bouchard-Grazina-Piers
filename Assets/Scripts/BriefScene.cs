using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BriefScene : MonoBehaviour {

       public void NewGame()
    {
        SceneManager.LoadScene("Brief");
    }

    public void Commandes()
    {
        SceneManager.LoadScene("Commandes");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("City");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
