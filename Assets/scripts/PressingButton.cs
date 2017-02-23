using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PressingButton : MonoBehaviour {

    public string LevelOne;

    public void OnButtonDown()
    {

        SceneManager.LoadScene(LevelOne);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
