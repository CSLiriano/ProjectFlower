using UnityEngine;
using System.Collections;

public class MovingPlat : MonoBehaviour {

    public Transform[] Waypoints;
    public int PlatSpeed;
    public int a;

    public GameObject PlayerGuy;
    public GameObject PlatformGuy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[a].position, PlatSpeed * Time.deltaTime);

        if (transform.position == Waypoints[a].position)
        {

            a++;

        }

        if (a == 2)
        {

            a = 0;

        }

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.name);

        if (other.gameObject.tag == "Player")
        {

            PlayerGuy.transform.parent = PlatformGuy.transform;
         //   other.transform.parent = transform.parent;
            Debug.Log("This is the player's parent now");
            Debug.Log(PlayerGuy.transform.parent.name);

        }

    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            other.transform.parent = null;
            Debug.Log("The player has no parent");
        }

    }
}
