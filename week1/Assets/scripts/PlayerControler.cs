using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject PlayerA;
    public float force;
    Rigidbody2D rb;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World! ");
        rb = GetComponent<Rigidbody2D>();
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(Vector2.right*force);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(right))//if D is pressed
        {
            rb.AddForce(Vector2.right * force);//apply a force using the "force" var
        }
        else if (Input.GetKey(left))
        {
            rb.AddForce(Vector2.left * force);
        }
        else if (Input.GetKey(up))
        {
            rb.AddForce(Vector2.up * force);
        }
        else if (Input.GetKey(down)) {
            rb.AddForce(Vector2.down * force);
        }


        }
    }
