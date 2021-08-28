using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawnScript : MonoBehaviour
{
    public Transform[] letter_spawn_points;
    public GameObject letter;
    private int random_spawn_point;
    private float random_coordinates_x;
    private float random_coordinates_y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnDrawGizmos()
    {
        for (int i = 0; i < letter_spawn_points.Length; i++)
        {
            Gizmos.DrawWireSphere(letter_spawn_points[i].position, 0.1f);
        }
    }

    public void spawnLetters(bool spawn_allowed, int number) 
    {
        Debug.Log(number);
        if(spawn_allowed) {
            for (int i = 0; i < number; i++)
            {
                random_spawn_point = Random.Range(0, letter_spawn_points.Length);
                random_coordinates_x = Random.Range(-0.15f, 0.15f);
                random_coordinates_y= Random.Range(-0.15f, 0.15f);
                GameObject letters = Instantiate(letter, letter_spawn_points[random_spawn_point].position + new Vector3(random_coordinates_x,random_coordinates_y,0),  Quaternion.identity);
                // letter.GetComponent<Rigidbody>().velocity = new Vector2(-10f, 0f);
            }  
        }
    }
}