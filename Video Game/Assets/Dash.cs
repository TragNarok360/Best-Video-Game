using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    bool Dashes = true;
    bool Unalive = true;
 
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start WaitStuff");
        StartCoroutine(WaitStuff());
        //Debug.Log("WaitStuff Started");
    }

    // Update is called once per frame
    IEnumerator WaitStuff()
    {
        // Debug.Log("Wait Stuff Loop Start");
        //Debug.Log("Boost = " + GravityProb.Boost);
        while (true)
        {
            yield return new WaitForSeconds(0.001f);
            if (Input.GetKey(KeyCode.Space))
            {
               // Debug.Log("hi" + Dashes);
                if (Dashes == true)
                {
                   // Debug.Log("Dash nyoonm");
                    GravityProb.Boost = 35f;
                    Dashes = false;
                    Unalive = false;

                   
                    // Physics2D.gravity = new Vector2(0, speed);


                    yield return new WaitForSeconds(1);
                    Debug.Log(GravityProb.Boost);
                    GravityProb.Boost = 0f;
                    Unalive = true;
                    yield return new WaitForSeconds(4);
                    Debug.Log("Dash ready");
                    Dashes = true;
                }
            }
        }
        void Update()
        {
            string hi = "grieughuiegiher";
        }
    }
}

