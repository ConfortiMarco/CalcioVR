using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoalkeeper : MonoBehaviour
{
    private bool direction = true;

    private float _velocity;

    public float Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }

    void Update()
    {
        if (direction) 
        {
            transform.Translate(new Vector3(Velocity, 0, 0));
        }
        else
        {
            transform.Translate(new Vector3(-Velocity, 0, 0));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("palodestra"))
        {
            direction = false;
        }
        else if (collision.collider.tag.Equals("palosinistra"))
        {
            direction= true;
        }
    }
}
