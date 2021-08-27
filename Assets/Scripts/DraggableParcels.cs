using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableParcels : MonoBehaviour
{



    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject ParcelSnap1;
    public GameObject ParcelSnap2;
    public GameObject ParcelSnap3;
    public GameObject ParcelSnap4;
    public GameObject ParcelSnap5;
    private Vector3 ParcelSnap1Pos;
    private Vector3 ParcelSnap2Pos;
    private Vector3 ParcelSnap3Pos;
    private Vector3 ParcelSnap4Pos;
    private Vector3 ParcelSnap5Pos;
    private bool inCorrectPlace1 = false;
    private bool inCorrectPlace2 = false;
    private bool inCorrectPlace3 = false;
    private bool inCorrectPlace4 = false;
    private bool inCorrectPlace5 = false;
    private SoundHandler sh;

    void Start()
    {

        ParcelSnap1Pos = ParcelSnap1.GetComponent<Transform>().position;
        ParcelSnap2Pos = ParcelSnap2.GetComponent<Transform>().position;
        ParcelSnap3Pos = ParcelSnap3.GetComponent<Transform>().position;
        ParcelSnap4Pos = ParcelSnap4.GetComponent<Transform>().position;
        ParcelSnap5Pos = ParcelSnap5.GetComponent<Transform>().position;
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
        if (other.gameObject.name == "ParcelSnap1")
        {
            Debug.Log("the drag item is inside drop place 1");
            inCorrectPlace1 = true;
        }
        if (other.gameObject.name == "ParcelSnap2")
        {
            Debug.Log("the drag item is inside drop place 2");
            inCorrectPlace2 = true;
        }
        if (other.gameObject.name == "ParcelSnap3")
        {
            Debug.Log("the drag item is inside drop place 3");
            inCorrectPlace3 = true;
        }
        if (other.gameObject.name == "ParcelSnap4")
        {
            Debug.Log("the drag item is inside drop place 4");
            inCorrectPlace4 = true;
        }
        if (other.gameObject.name == "ParcelSnap5")
        {
            Debug.Log("the drag item is inside drop place 5");
            inCorrectPlace5 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "ParcelSnap1")
        {
            Debug.Log("the drag item has left drop place 1");
            inCorrectPlace1 = false;
        }
        if (other.gameObject.name == "ParcelSnap2")
        {
            Debug.Log("the drag item has left drop place 2");
            inCorrectPlace2 = false;
        }
        if (other.gameObject.name == "ParcelSnap3")
        {
            Debug.Log("the drag item has left drop place 3");
            inCorrectPlace3 = false;
        }
        if (other.gameObject.name == "ParcelSnap4")
        {
            Debug.Log("the drag item has left drop place 4");
            inCorrectPlace4 = false;
        }
        if (other.gameObject.name == "ParcelSnap5")
        {
            Debug.Log("the drag item has left drop place 5");
            inCorrectPlace5 = false;
        }
    }



    void OnMouseUp()
    {

        if (inCorrectPlace1 == true)
        {
            this.gameObject.transform.position = ParcelSnap1Pos;
            sh.Playpop();
        }

        if (inCorrectPlace2 == true)
        {
            this.gameObject.transform.position = ParcelSnap2Pos;
            sh.Playpop();
        }
        if (inCorrectPlace3 == true)
        {
            this.gameObject.transform.position = ParcelSnap3Pos;
            sh.Playpop();
        }
        if (inCorrectPlace4 == true)
        {
            this.gameObject.transform.position = ParcelSnap4Pos;
            sh.Playpop();
        }
        if (inCorrectPlace5 == true)
        {
            this.gameObject.transform.position = ParcelSnap5Pos;
            sh.Playpop();
        }
        

    }



}
