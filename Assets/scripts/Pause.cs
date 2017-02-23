using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public bool Paused;
    public GameObject MyPauseMenu;
	// Use this for initialization
	void Start ()
    {
        MyPauseMenu.SetActive(false);
        
        //Cursor.visible = false;

    }

    void Awake()
    {

        Paused = false;

    }
	
	// Update is called once per frame
	void Update () {

        PauseMode();
	}

    void PauseMode()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("you pressed P");
            Paused = !Paused;



            if (Paused)
            {

                MyPauseMenu.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;

            }

            else if (!Paused)
            {

                MyPauseMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

}
