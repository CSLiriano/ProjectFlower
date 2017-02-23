using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {

    public GameObject cubullet;
    public GameObject shoot;
    public float shotTimer;
    public bool shot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("z") && shot == true) 
        
        {

            Instantiate(shoot, cubullet.transform.position, transform.rotation);
            shot = false;
        }

        if (shot == false) 
        
        {

            shotTimer -= Time.deltaTime;

            if (shotTimer <= 0) 
            
            {

                shot = true;
                shotTimer = .5f;
            
            }

        }

	
	}
}
