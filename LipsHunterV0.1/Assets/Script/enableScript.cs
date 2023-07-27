using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableScript : MonoBehaviour
{
    public Behaviour enabledScript;

    void Start()
    {
        enabledScript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
