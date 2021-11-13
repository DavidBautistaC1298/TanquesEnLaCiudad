using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform objetivo;
    public float speed = 5f;
    float rango = 2.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 verObjetivo = new Vector3(objetivo.position.x, this.transform.position.y, objetivo.position.z);
        this.transform.LookAt(verObjetivo);
        if (Vector3.Distance(transform.position, objetivo.position) > rango)
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
