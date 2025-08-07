using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    private bool isMoving=false;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)|| MovementInput.Instance.swipeLeft)
        {
            rb.velocity =Vector3.left*speed*Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || MovementInput.Instance.swipeRight)
        {
            rb.velocity = Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || MovementInput.Instance.swipeUp)
        {
            rb.velocity = Vector3.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || MovementInput.Instance.swipeDown)
        {
            rb.velocity = -Vector3.forward * speed * Time.deltaTime;
        }
    }
}
