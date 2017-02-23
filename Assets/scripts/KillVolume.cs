using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillVolume : MonoBehaviour {

    public string LevelOne;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) 
    { 
    
    if(other.gameObject.name == "Nymph Fairy")
    {
            SceneManager.LoadScene("LevelOne");
       // Application.LoadLevel(Application.loadedLevel);
        Debug.Log("you went through");
    }

    }

}
