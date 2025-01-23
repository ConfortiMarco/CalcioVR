using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject door;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("key")) {
            door.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}
