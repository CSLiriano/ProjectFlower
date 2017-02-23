using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{

    public float moveSpeed;
    public float jumpSpeed;
    public bool isGrounded;
    public bool touchingWall = false;
    public bool CanMove = true;

    public Quaternion LookLeft = new Quaternion(0, 0, 0, 0);
    public Quaternion LookRight = new Quaternion(0, 0, 0, 0);
    public Quaternion StartQuat = new Quaternion(0, 0, 0, 0);

    Animator anim;

    Vector3 movement;
    int floorMask;
    float camRayLength = 100f;

    //  public Transform move;
    public Rigidbody rb;
    // Use this for initialization
    void Awake()
    {

        anim = GetComponent<Animator>();

        rb = this.gameObject.GetComponent<Rigidbody>();
        //move = this.gameObject.GetComponent<Transform>();

        floorMask = LayerMask.GetMask("Floor");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Jump(350);
        if (CanMove == true)
        {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            // float moveVertical = Input.GetAxisRaw("Vertical");

            Moving(moveHorizontal, 0);

            

        }

        else
        {

          //  anim.SetBool("Fly Forward", false);

        }

        Turning();

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            // = LookLeft;

            //Quaternion theScale = transform.localRotation;

            //theScale.y = -1;

            //transform.localRotation = theScale;
            gameObject.transform.rotation = LookLeft;

            //theScale.z = -1;

            //transform.localScale = theScale;


            //this.gameObject.transform.localScale(0, -1, 0);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            gameObject.transform.rotation = LookRight;

            //Quaternion theScale = transform.localRotation;

            //theScale.y = 1;

            //transform.localRotation = theScale;

            //Vector3 theScale = transform.localScale;

            //theScale.z = 1;

            //transform.localScale = theScale;

            //this.gameObject.transform.localScale(0, -1, 0);

        }


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {

            anim.SetBool("Fly Forward", true);

        }

        else
        {

            anim.SetBool("Fly Forward", false);

        }

    }

    void Moving(float moveHorizontal, float moveVertical)
    {

        movement.Set(moveHorizontal, 0, moveVertical);

        movement = movement.normalized * moveSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }

    void Turning()
    {

        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition); //array coming from camera is assigned to the mouse cursor's position that casts an array from the mouse cursor forward into the scene   

        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {

            Vector3 playerToMouse = floorHit.point - transform.position;

            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

            rb.MoveRotation(newRotation);

        }

    }


    void Jump(float amount)
    {
        jumpSpeed = amount;
        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * amount);
                isGrounded = false;


                Debug.Log("you jumped");

            }
        }


    }

    void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag == "Platform")
        {

            isGrounded = true;
            Debug.Log("touching the ground");

        }

        if (other.collider.tag == "MovingPlatform")
        {

            isGrounded = true;
            Debug.Log("touching the ground");

        }


    }

    //void OnTriggerEnter(Collider other)
    //{

    //    if (other.gameObject.tag == "MovingPlatform")
    //    {

    //        this.gameObject.transform.parent = other.transform.parent;

    //    }

    //}

    //void OnTriggerExit(Collider other)
    //{

    //    if (other.gameObject.tag == "MovingPlatform")
    //    {

    //        this.transform.parent = null;

    //    }

    //}

}
