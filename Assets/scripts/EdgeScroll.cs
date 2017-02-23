using UnityEngine;
using System.Collections;

public class EdgeScroll : MonoBehaviour {

    public float mPixel = 2.0f;
    public float mSpeed = 3.0f;

    private Vector3 DownDirection = Vector3.down;
    private Vector3 UpDirection = Vector3.up;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.mousePosition.y >= Screen.height - mPixel) 
        {

            transform.position += UpDirection * Time.deltaTime * mSpeed;
            Debug.Log("Moving Up");
        
        }


        if (Input.mousePosition.y <= Screen.height + mPixel)
        {

            transform.position += DownDirection * Time.deltaTime * mSpeed;
            Debug.Log("Moving Down");
        }

	}
}
