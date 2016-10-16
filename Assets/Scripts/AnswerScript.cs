using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnswerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Culprit()
    {
        SceneManager.LoadScene("Bravo"); 
    }

    public void NoCulprit()
    {
        SceneManager.LoadScene("Dommage");
    }
}
