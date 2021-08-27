using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableLetter : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject[] LetterSnap = new GameObject[5];
    private Vector3[] LetterSnapPos = new Vector3[] { 
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
    public PropertyScript letter_property;
    public FlagArray flag_array;
    public GameObject flag;

    void Start()
    {
        GameObject flag = new GameObject();
        for (int i = 0; i < LetterSnapPos.Length; i++)
        {
            LetterSnapPos[i] = LetterSnap[i].GetComponent<Transform>().position;
        }
    }

    void OnMouseDown()
    {
        startPosition = this.gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        flag = flag_array.spawnNewFlag(letter_property.flag_country_position, letter_property.flag_continent);
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
            case "LetterSnap1" :
                inCorrectPlace[0] = true;
                break;
            case "LetterSnap2" :
                inCorrectPlace[1] = true;
                break;
            case "LetterSnap3" :
                inCorrectPlace[2] = true;
                break;
            case "LetterSnap4" :
                inCorrectPlace[3] = true;
                break;
            case "LetterSnap5" :
                inCorrectPlace[4] = true;
                break;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    { 
        switch (other.gameObject.name)
        {
            case "LetterSnap1" :
                inCorrectPlace[0] = false;
                break;
            case "LetterSnap2" :
                inCorrectPlace[1] = false;
                break;
            case "LetterSnap3" :
                inCorrectPlace[2] = false;
                break;
            case "LetterSnap4" :
                inCorrectPlace[3] = false;
                break;
            case "LetterSnap5" :
                inCorrectPlace[4] = false;
                break;
        }
    }



    void OnMouseUp()
    {
        Destroy(flag);
        for (int i = 0; i < LetterSnapPos.Length; i++)
        {
            if(inCorrectPlace[i] == true) {
                LetterSnapPos[i].y -=0.3f;
                this.gameObject.transform.position = LetterSnapPos[i];
            }
        }
    }



}
