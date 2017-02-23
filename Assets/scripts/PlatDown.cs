using UnityEngine;
using System.Collections;

public class PlatDown : MonoBehaviour {

    public Rigidbody2D rb2D;
    public GameObject player;
    public float speed;
    public float timer;
    public bool fall;

	// Use this for initialization
	void Start () {

        rb2D = GetComponent<Rigidbody2D>();

	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("FUCK YOU");
        if (other.gameObject == player) 
        {
            
            fall = true;
            rb2D.isKinematic = false;
        }

        if(fall == true)
        {

            this.transform.position = Vector3.down * speed;
        
        }
    }

	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D Col)
    {
        
        if(Col.gameObject.tag == "Player")
        {
            Debug.Log(Col.name);
            Invoke("Fall", timer);
        }
    }

    void Fall() 
    {

        fall = true;
        rb2D.isKinematic = false;
    
    
    }
}
