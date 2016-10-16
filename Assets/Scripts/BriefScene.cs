using UnityEngine;
using System.Collections;

public class BriefScene : MonoBehaviour {

    public string startGame;

    public string Options;

    public string Menu;

    public void NewGame()
    {
        Application.LoadLevel(startGame);
    }

    public void Commandes()
    {
        Application.LoadLevel(Options);
    }

    public void BackMenu()
    {
        Application.LoadLevel(Menu);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
