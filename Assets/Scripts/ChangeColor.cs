using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void ColorChange()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
