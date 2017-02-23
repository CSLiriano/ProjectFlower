using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public string LevelTwo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {

            SceneManager.LoadScene(LevelTwo);
           

        }

    }

}
