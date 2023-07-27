using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayText : MonoBehaviour
{
    public GameObject uiObject;
    public Behaviour enabledScript;
    public float destroyTime = 0.1f;

    void Start()
    {
        uiObject.SetActive(false);
        enabledScript.enabled = false;
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            enabledScript.enabled = true;
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
