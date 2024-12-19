using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityProb : MonoBehaviour
{   // bunch  of bools and otrher stuff
    float speed = 15f;
    public static  float Boost = 0f;
    private Rigidbody2D body;
    bool LW;
    bool RW;
    bool C;
    bool F;
    float grav;
    bool dash = true;
    bool Unalive = true;
    void Start()
    {

        Debug.Log("hi ti hi hih hih hi");
    }

    
    private void Awake()
    {

        body = GetComponent<Rigidbody2D>();
        

    }   

    void Update()
    {
        grav = speed + Boost;
        // physics stuff probably
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(0, grav);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0, -grav);
            
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-grav, 0);
            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(grav, 0);
            
        }

    }
}
  