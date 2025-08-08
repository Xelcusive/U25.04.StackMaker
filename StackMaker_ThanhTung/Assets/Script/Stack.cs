    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dashpickup"))
        {
            other.gameObject.CompareTag("normal");
        }
    }
}
