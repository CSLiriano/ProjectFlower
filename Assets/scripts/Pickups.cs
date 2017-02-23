using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pickups : MonoBehaviour {

    public int Coins = 0;
    public int Ammo = 0;

    public Text AmmoText;
    public Text CoinText;
    // Use this for initialization
    void Start () {

        AmmoText.text = "";

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Ammo")
        {

            Ammo += 20;
            Destroy(other.gameObject);
            AmmoText.text = "" + Ammo;

        }

        if (other.tag == "Coin")
        {
            Coins += 1;
            Destroy(other.gameObject);
            CoinText.text = "" + Coins;

        }

    }

}
