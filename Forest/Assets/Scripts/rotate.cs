using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float speed;
    float ne;

    // Start is called before the first frame update
    void Update()
    {
        ne = speed * Time.deltaTime;
        transform.Rotate(Vector3.up * ne, Space.World);

    }

}
