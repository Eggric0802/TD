using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = hoverColor;
    }

    
}
