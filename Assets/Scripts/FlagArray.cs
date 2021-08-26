using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagArray : MonoBehaviour
{

    public GameObject[] flagArray;
    private int rand;
    public Vector3 flagPos;
    public Transform flagTrans;




    // Start is called before the first frame update
    void Start()
    {
        flagPos.Set(flagTrans.position.x, flagTrans.position.y, 0);
        //Instantiate(flagArray[rand], flagPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNewFlag()
    {
        rand = Random.Range(0, flagArray.Length);
        Instantiate(flagArray[rand], flagPos, Quaternion.identity);




    }
}
