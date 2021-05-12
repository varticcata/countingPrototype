using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    float yDestroyBound = 0;
    void Update()
    {
        if (transform.position.y < yDestroyBound)
        {
            Destroy(gameObject);
        }
    }
}
