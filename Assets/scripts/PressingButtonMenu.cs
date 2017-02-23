using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PressingButtonMenu : MonoBehaviour {

    public string MainMenu;

    void OnButtonDown() 
    {

        SceneManager.LoadScene(MainMenu);
    
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
