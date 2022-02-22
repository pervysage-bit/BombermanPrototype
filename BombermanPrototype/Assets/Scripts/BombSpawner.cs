using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour
{
    public GameObject playerControl;
    public Tilemap tilemap;
    public GameObject bombPrefab;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            SpawnBombAtPlayerPosition();
        }       
        
    }

    private void SpawnBombAtPlayerPosition()
    {

        transform.position = playerControl.transform.position;
        Instantiate(bombPrefab, playerControl.transform.position, Quaternion.identity);
        

    }
}
