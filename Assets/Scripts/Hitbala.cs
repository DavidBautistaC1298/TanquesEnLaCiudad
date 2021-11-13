using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbala : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
