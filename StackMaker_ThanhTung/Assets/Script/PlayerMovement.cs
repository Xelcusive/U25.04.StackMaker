using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance;
    private Rigidbody rb;

    public GameObject DashParent;
    public GameObject PrevDash;
    public float speed;

    private bool isMoving=false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
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
    public void PickDash(GameObject dashOb )
    {
        dashOb.transform.SetParent(DashParent.transform);
        Vector3 pos = PrevDash.transform.localPosition;
        pos.y-=1.19f;
        dashOb.transform.localPosition = pos;
        Vector3 charactorPos = transform.localPosition;
        charactorPos.y += 1.19f;
        transform.localPosition = charactorPos;
        PrevDash=dashOb;
        PrevDash.GetComponent<BoxCollider>().isTrigger = false;
    }
}
