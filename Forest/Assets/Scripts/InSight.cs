using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InSight : MonoBehaviour
{
    public Transform player;
    static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = player.position - this.transform.position;
        //float angle = Vector3.Angle(direction, this.transform.forward);

        if (Vector3.Distance(player.position, this.transform.position) < 8) //&& angle < 180
        {
            anim.SetTrigger("IsAttacking");
        }
        /*else
        {
            anim.SetTrigger("IsAttacking", false);
        }*/

    }
}
