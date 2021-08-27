using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandlerLetters : MonoBehaviour
{



    private AudioSource pop2;




    // Start is called before the first frame update
    void Start()
    {

        pop2 = GetComponent<AudioSource>();


    }

    public void Playpop2()
    {
        pop2.Play();

    }





}
