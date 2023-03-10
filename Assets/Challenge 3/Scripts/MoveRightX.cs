using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    public float rightBound = 15.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < rightBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
