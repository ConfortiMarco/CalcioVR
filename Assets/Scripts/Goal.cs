using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject gameManager;
    [SerializeField]
    private GameObject ball;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("palla"))
        {
            gameManager.GetComponent<ScoreManager>().Score++;
            GetComponent<AudioSource>().Play();
            Destroy(collision.collider.gameObject);

            Instantiate(ball, new Vector3(6.23f, 4.73f, 6.01f), Quaternion.identity);
        }
    }
}
