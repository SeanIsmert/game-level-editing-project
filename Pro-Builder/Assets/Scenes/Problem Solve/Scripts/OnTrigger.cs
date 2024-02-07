using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public GameObject objectToAppear; // The object that is going to appear from being deactivated

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //told that compare tag was better than == "player"
        {
            // Enable the object
            objectToAppear.SetActive(true);

            // Destroy the trigger
            Destroy(gameObject);
        }
    }
}
