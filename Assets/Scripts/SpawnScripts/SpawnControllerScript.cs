using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControllerScript : MonoBehaviour
{
    public LetterSpawnScript letter_spawn_script;
    public ParcelSpawnScript parcel_spawn_script;
    public TimerScript timer_script;
    private int minute;
    private int past_minute;
    private float letter_spawn_rate = 5f;
    private float parcel_spawn_rate = 6f;
    private int number_of_items;

    public bool spawn_allowed;
    // Start is called before the first frame update
    void Start()
    {
        spawn_allowed = true;
        number_of_items = 1;
        past_minute = 0;
        callSpawns();
    }

    // Update is called once per frame
    void Update()
    {
        minute = getMinute();
        calculateTime();
    }

    void callSpawns() 
    {
        StartCoroutine(spawnLetter());
        StartCoroutine(spawnParcel());
    }

    int getMinute() {
        return timer_script.getMinute();
    }

    void calculateTime() {
        if(minute == past_minute+1) {
            letter_spawn_rate -= 0.5f;
            parcel_spawn_rate -= 0.5f;
            past_minute +=1;
        }
        switch (minute) {
            case 3 :
                number_of_items = 2;
                break;
            case 6 :
                number_of_items = 3;
                break;
            default:
                break;
        }            
    }

    IEnumerator spawnLetter() {
        // Debug.Log("SPAWNIN LETTER");
        yield return new WaitForSeconds(letter_spawn_rate);
        letter_spawn_script.spawnLetters(spawn_allowed, number_of_items);
        StartCoroutine(spawnLetter());
    }

    IEnumerator spawnParcel(){
        yield return new WaitForSeconds(parcel_spawn_rate);
        parcel_spawn_script.spawnParcels(spawn_allowed, number_of_items);
        StartCoroutine(spawnParcel());
    }
}
