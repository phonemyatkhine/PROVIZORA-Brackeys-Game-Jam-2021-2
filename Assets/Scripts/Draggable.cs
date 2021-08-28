using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    
    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject LetterSnap1;
    public GameObject LetterSnap2;
    public GameObject LetterSnap3;
    public GameObject LetterSnap4;
    public GameObject LetterSnap5;
    private Vector3 LetterSnap1Pos;
    private Vector3 LetterSnap2Pos;
    private Vector3 LetterSnap3Pos;
    private Vector3 LetterSnap4Pos;
    private Vector3 LetterSnap5Pos;
    private bool inCorrectPlace1 = false;
    private bool inCorrectPlace2 = false;
    private bool inCorrectPlace3 = false;
    private bool inCorrectPlace4 = false;
    private bool inCorrectPlace5 = false;
    private int rand;
    private SoundHandler sh;


    void Start()
    {
    
        LetterSnap1Pos = LetterSnap1.GetComponent<Transform>().position;
        LetterSnap2Pos = LetterSnap2.GetComponent<Transform>().position;
        LetterSnap3Pos = LetterSnap3.GetComponent<Transform>().position;
        LetterSnap4Pos = LetterSnap4.GetComponent<Transform>().position;
        LetterSnap5Pos = LetterSnap5.GetComponent<Transform>().position;
        sh = GetComponent<SoundHandler>();


    }

    void OnMouseDown()
    {

        startPosition = this.gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        
       

    }
    void OnMouseDrag()
    {

        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        this.transform.position = curPosition;
     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "LetterSnap1")
        {
            Debug.Log("the drag item is inside drop place 1");
            inCorrectPlace1 = true;
        }
        if (other.gameObject.name == "LetterSnap2")
        {
            Debug.Log("the drag item is inside drop place 2");
            inCorrectPlace2 = true;
        }
        if (other.gameObject.name == "LetterSnap3")
        {
            Debug.Log("the drag item is inside drop place 3");
            inCorrectPlace3 = true;
        }
        if (other.gameObject.name == "LetterSnap4")
        {
            Debug.Log("the drag item is inside drop place 4");
            inCorrectPlace4 = true;
        }
        if (other.gameObject.name == "LetterSnap5")
        {
            Debug.Log("the drag item is inside drop place 5");
            inCorrectPlace5 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "LetterSnap1")
        {
            Debug.Log("the drag item has left drop place 1");
            inCorrectPlace1 = false;
        }
        if (other.gameObject.name == "LetterSnap2")
        {
            Debug.Log("the drag item has left drop place 2");
            inCorrectPlace2 = false;
        }
        if (other.gameObject.name == "LetterSnap3")
        {
            Debug.Log("the drag item has left drop place 3");
            inCorrectPlace3 = false;
        }
        if (other.gameObject.name == "LetterSnap4")
        {
            Debug.Log("the drag item has left drop place 4");
            inCorrectPlace4 = false;
        }
        if (other.gameObject.name == "LetterSnap5")
        {
            Debug.Log("the drag item has left drop place 5");
            inCorrectPlace5 = false;
        }
    }



    void OnMouseUp()
    {

        if (inCorrectPlace1 == true)
        {
            this.gameObject.transform.position = LetterSnap1Pos;
            sh.Playpop();
        }

        if (inCorrectPlace2 == true)
        {
            this.gameObject.transform.position = LetterSnap2Pos;
            sh.Playpop();
        }
        if (inCorrectPlace3 == true)
        {
            this.gameObject.transform.position = LetterSnap3Pos;
            sh.Playpop();
        }
        if (inCorrectPlace4 == true)
        {
            this.gameObject.transform.position = LetterSnap4Pos;
            sh.Playpop();
        }
        if (inCorrectPlace5 == true)
        {
            this.gameObject.transform.position = LetterSnap5Pos;
            sh.Playpop();
        }
        

    }



}
