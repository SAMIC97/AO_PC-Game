using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiñaControles : MonoBehaviour
{
    static Animator anim;
    float speed = 20.0f;
    float rotationSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if(Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("IsJumping");
        }

        if (translation != 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("IsIdle", false);
        }
        else
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("IsIdle", true);
        }

        if(rotation < 0)
        {
            anim.SetBool("turnLeft", true);
            //print("menor de 0");
        }
        else if(rotation > 0)
        {
            anim.SetBool("turnRight", true);
            //print("mayor de 0");
        }
        if (rotation == 0)
        {
            //print("0");
            anim.SetBool("turnRight", false);
            anim.SetBool("turnLeft", false);
        }

        /*if(translation < 0)
        {
            this.transform.Rotate(Input.GetAxis("Horizontal"))
        }*/
    }
}
