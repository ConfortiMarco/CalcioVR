using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeper : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("palla"))
        {
            GetComponent<AudioSource>().Play();
            Destroy(collision.collider.gameObject);
            Instantiate(ball, new Vector3(6.23f, 4.73f, 6.01f), Quaternion.identity);
        }
    }

}
