//using UnityEngine;
//using System.Collections;

//public class HealthModifierManager : MonoBehaviour
//{
//    public bool _IsHurtful = false;
//    public int _Amount = 0;

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        Debug.Log("Hello World");

//        if(_IsHurtful)
//        {
//            other.gameObject.transform.parent.GetComponent<health>().TakeDamage(_Amount);
//        }
//        else
//        {
//            other.gameObject.transform.parent.GetComponent<health>().HealUp(_Amount);
//        }

//        Destroy(this.gameObject);
//    }
//}
