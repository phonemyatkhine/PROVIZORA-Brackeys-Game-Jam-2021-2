using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicTracks : MonoBehaviour
{


    public AudioSource Track1;

    public AudioSource Track2;

    public AudioSource Track3;

    public int trackSelector;





    // Start is called before the first frame update
    void Start()
    {

        Track1.Play();
        trackSelector = 1;

   



    }

    // Update is called once per frame
    void Update()
    {

        if (trackSelector == 1 && Track1.isPlaying == false)
        {
            Track2.Play();
            trackSelector = 2;
            Debug.Log("track2 playing");

        }
        if (trackSelector == 2 && Track2.isPlaying == false)
        {
            Track3.Play();
            trackSelector = 3;
            Debug.Log("track3 playing");

        }




    }
}
