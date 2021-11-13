using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTanque : MonoBehaviour
{

    float speed = 5;
    public Transform gunpoint;
    public Rigidbody bala;
    public int shootforce = 50;

    // Update is called once per frame
    void Update()
    {

       // if(speed > 0) { speed = speed - 0.2f; }

       //if (speed < 0) { speed = speed + 0.2f; }

        if (Input.GetKey(KeyCode.W)){  speed = speed + 1f; }
        
        if (Input.GetKey(KeyCode.S)){ speed = speed - 1f; }

        if (Input.GetKey(KeyCode.A)){ transform.Rotate(0,-0.2f,0); }
        
        if (Input.GetKey(KeyCode.D)){ transform.Rotate(0, 0.2f, 0); }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody newbala;
            newbala = Instantiate(bala, gunpoint.position, gunpoint.rotation);
            newbala.velocity = transform.TransformDirection(new Vector3(0, 0, shootforce));
        }
    }
}
