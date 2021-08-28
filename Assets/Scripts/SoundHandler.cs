using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{

  

    private AudioSource pop;
  



    // Start is called before the first frame update
    void Start()
    {

        pop = GetComponent<AudioSource>();


    }

    public void Playpop()
    {
        pop.Play();

    }

  




}
