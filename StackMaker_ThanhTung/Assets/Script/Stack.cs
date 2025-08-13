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
            PlayerMovement.Instance.PickDash(other.gameObject);
            other.gameObject.AddComponent<Rigidbody>();
            other.gameObject.GetComponent<Rigidbody>().useGravity= false;
            other.gameObject.GetComponent<Rigidbody>().isKinematic=true;
            other.gameObject.AddComponent<Stack>();
            Destroy(this);
        }
    }
}
