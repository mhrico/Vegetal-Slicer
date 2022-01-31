using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
         if(col.tag == "Blade")
        {
            Debug.Log("Vegetal Destroyed!!!");
            Destroy(gameObject);
        }
    }
}
