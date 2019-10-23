using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float altura_salto;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float speed = Time.deltaTime * 10;
        float rotationSpeed = Time.deltaTime * 100;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 ejeZ = new Vector3(0, 0, speed);
            gameObject.transform.Translate(ejeZ);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 ejeZ2 = new Vector3(0, 0, -speed);
            gameObject.transform.Translate(ejeZ2);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 ejeY = new Vector3(0, rotationSpeed, 0);
            gameObject.transform.Rotate(ejeY);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 ejeY2 = new Vector3(0, -rotationSpeed, 0);
            gameObject.transform.Rotate(ejeY2);
        }
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = new Vector3(0, altura_salto, 0);
            }
        }

    }

}

