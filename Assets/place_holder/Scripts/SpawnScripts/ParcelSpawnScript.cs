using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcelSpawnScript : MonoBehaviour
{
    public Transform[] parcel_spawn_points;
    public GameObject parcel;
    private int random_spawn_point;
    private float random_coordinates_x;
    private float random_coordinates_z;
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
        for (int i = 0; i < parcel_spawn_points.Length; i++)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(parcel_spawn_points[i].position, 0.1f);
        }
    }

    public void spawnParcels(bool spawn_allowed, int number) 
    {
        if(spawn_allowed) {
            for (int i = 0; i < number; i++)
            {
                random_spawn_point = Random.Range(0, parcel_spawn_points.Length);
                random_coordinates_x = Random.Range(-0.25f, 0.25f);
                random_coordinates_z = Random.Range(-0.25f, 0.25f);
                GameObject parcels = Instantiate(parcel, parcel_spawn_points[random_spawn_point].position + new Vector3(random_coordinates_x,0,random_coordinates_z), Quaternion.Euler(90,0,0));
                // letter.GetComponent<Rigidbody>().velocity = new Vector2(-10f, 0f);
            }
        }
    }
}
