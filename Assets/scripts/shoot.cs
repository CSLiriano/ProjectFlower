using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float timer;
    public float geo;

	// Use this for initialization
	void Start () {

        geo = GameObject.FindGameObjectWithTag("Player").transform.GetChild(2).transform.rotation.y;

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {



        timer -= Time.deltaTime;

        if (timer <= 0) 
        {

            Destroy(gameObject);
        
        }


        if (geo >= 0.707105) 
        {

            rb.AddForce(new Vector3(speed, 0, 0));
            //transform.position += Vector3.right * speed;
        
        }

        if (geo <= -0.707105)
        {

            rb.AddForce(new Vector3(-speed, 0, 0));
            //transform.position += Vector3.left * speed;

        }

	}
}
