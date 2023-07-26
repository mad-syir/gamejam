using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour
{
    int notes = 0; //counter
    [SerializeField] Text noteText; //use this to see how many notes you collect on screen
    private void OnTriggerEnter(Collider other)
    {
        //if trigger is true use this method
        if (other.gameObject.CompareTag("Notes"))
        {
            Destroy(other.gameObject);
            notes++;
            Debug.Log("Notes: " + notes);
            //noteText.text = "Notes collected: " + notes;
        }
    }
}
