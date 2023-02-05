using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    public float leftBound = -100f;
    public float rightBound = -100f;
    private SpawnManagerX SpawnManagerScript;
    
    

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        SpawnManagerScript = GameObject.Find("Spawn_Manager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // If game is not over, move to the left
        if (!playerControllerScript.gameOver && transform.position.x > (0))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        if (!playerControllerScript.gameOver && transform.position.x < (0))
        {
            transform.Translate(Vector3.left * (speed * -1) * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
        if (transform.position.x > rightBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
    }
    

   
}
