﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{

    public Text HealthText;

    //public Image


    //public GameObject[] _DaSprite;      //gameobject array holding the different sprites
    //public bool takedmg, heal;          //bools that tell you if you take damage or heal
    //public int healthInt;               //acts as the element of the array that you're currently on


    //public const int maxHealth = 100;       //your max health
    //public int currentHealth = maxHealth;   //your curren health = your max health
    //public bool isDead = false;             //you're not dead yet so it's automatically false
    //public bool mHealth;                    //Your main health bool

    //// Use this for initialization
    //void Start()
    //{
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Dead();
    //    sprites();
    //    if (currentHealth == 100)
    //    {

    //        mHealth = true;

    //    }
        

    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    //if (other.gameObject.tag == "projectile")
    //    //{
    //    //    TakeDamage(20);
    //    //    mHealth = false;
    //    //    takedmg = true;
    //    //    Debug.Log("you took damage");
    //    //    other.gameObject.SetActive(false);
    //    //}

    //    if (other.gameObject.tag == "healthPickup")
    //    {
    //        Debug.Log("yay");
    //        //if (mHealth == false)
    //        //{
    //        //    HealUp(20);
    //        //    Debug.Log("you healed");
    //        //    heal = true;
    //        //}
    //        //other.gameObject.SetActive(false);

    //    }



    //}

    //void sprites()
    //{
    //    if (takedmg == true)
    //    {
    //        _DaSprite[healthInt].SetActive(false);
    //        healthInt += 1;
    //        takedmg = false;
    //    }
    //    if (heal == true)
    //    {
    //        healthInt -= 1;
    //        _DaSprite[healthInt].SetActive(true);
    //        heal = false;
    //    }
    //}

    //public void TakeDamage(int amount)
    //{
    //    currentHealth -= amount;

    //    _DaSprite[healthInt].SetActive(false);
    //    healthInt += 1;
    //    takedmg = false;

    //    if (currentHealth <= 0)
    //    {
    //        //_DaSprite[4].SetActive(false);
    //        //_DaSprite[5].SetActive(false);
    //        currentHealth = 0;
    //        //isDead = true;
    //        this.gameObject.SetActive(false);
    //        //Application.LoadLevel(Application.loadedLevel);
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }




    //}

    //public void HealUp(int amounts) 
    //{

    //    currentHealth += amounts;

    //    healthInt -= 1;
    //    _DaSprite[healthInt].SetActive(true);
    //    heal = false;

    //    if (currentHealth >= 100)
    //    {

    //        currentHealth = 100;
    //        Debug.Log("you're at max health!");

    //    }
        

    //}

    //void Dead()
    //{
    //    if (isDead == true)
    //    {
    //        this.gameObject.SetActive(false);
    //        Debug.Log("you died");
    //    }
    //}


}
