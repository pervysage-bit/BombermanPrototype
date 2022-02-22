using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{

    private float speed = 5f;
    private float horizontalInput;
    private float verticalInput;
    Vector3Int obstacleMapTile;
   


    public Tilemap wallTilesObstacle;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
       

    }

    public void PlayerMovement()
    {

        Vector3 movetoPos = transform.position + new Vector3(horizontalInput, verticalInput);
        obstacleMapTile = wallTilesObstacle.WorldToCell(movetoPos);

        if (wallTilesObstacle.GetTile(obstacleMapTile) == null)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
