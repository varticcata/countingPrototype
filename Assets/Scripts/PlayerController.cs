using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    [SerializeField] float speed = 4.0f;
    [SerializeField] Text countText;
    float horizontalInput;
    int count = 0;
    float zRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Move the player on the horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(new Vector3(0,0,3) * horizontalInput * speed);
        PlayerBound();

    }

    //Destroy the objet when it collides with the player and update the score
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        count++;
        countText.text = "Count: " + count;
    }

    //Keep the player in the predefined boundaries
    void PlayerBound()
    {
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange); 
        } else if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
    }
}
