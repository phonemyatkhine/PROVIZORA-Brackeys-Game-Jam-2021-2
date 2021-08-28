using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableParcels : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject[] ParcelSnap = new GameObject[5];
    private Vector3[] ParcelSnapPos = new Vector3[] { 
        new Vector3(),
        new Vector3(),
        new Vector3(),
        new Vector3(),
        new Vector3(),
    };
    private bool[] inCorrectPlace = {
        false, 
        false,
        false,
        false,
        false
    }; 
    public PropertyScript Parcel_property;
    public FlagArray flag_array;
    public ScoreKeeper score_keeper;
    public GameObject flag;
    private string[] continents = {"africa","americas","asia","europe","oceania"};
    private SoundHandler sh;

    void Start()
    {
        for (int i = 0; i < ParcelSnapPos.Length; i++)
        {
            ParcelSnapPos[i] = ParcelSnap[i].GetComponent<Transform>().position;
        }
        sh = GetComponent<SoundHandler>();
    }

    void OnMouseDown()
    {
        startPosition = this.gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        flag = flag_array.spawnNewFlag(Parcel_property.flag_country_position, Parcel_property.flag_continent);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        this.transform.position = curPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.name)
        {
            case "ParcelSnap1" :
                inCorrectPlace[0] = true;
                break;
            case "ParcelSnap2" :
                inCorrectPlace[1] = true;
                break;
            case "ParcelSnap3" :
                inCorrectPlace[2] = true;
                break;
            case "ParcelSnap4" :
                inCorrectPlace[3] = true;
                break;
            case "ParcelSnap5" :
                inCorrectPlace[4] = true;
                break;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    { 
        switch (other.gameObject.name)
        {
            case "ParcelSnap1" :
                inCorrectPlace[0] = false;
                break;
            case "ParcelSnap2" :
                inCorrectPlace[1] = false;
                break;
            case "ParcelSnap3" :
                inCorrectPlace[2] = false;
                break;
            case "ParcelSnap4" :
                inCorrectPlace[3] = false;
                break;
            case "ParcelSnap5" :
                inCorrectPlace[4] = false;
                break;
        }
    }



    void OnMouseUp()
    {
        Destroy(flag);
        for (int i = 0; i < ParcelSnapPos.Length; i++)
        {
            if(inCorrectPlace[i] == true) {
                if(Parcel_property.flag_continent == continents[i]) {
                    score_keeper.addScore(35);
                } else {
                    score_keeper.error();
                }
                this.gameObject.transform.position = ParcelSnapPos[i];
                this.enabled = false;
                sh.Playpop();
            }
        }
    }
}
