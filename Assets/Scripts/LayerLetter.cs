using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerLetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.layer = LayerMask.NameToLayer("Letter");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
