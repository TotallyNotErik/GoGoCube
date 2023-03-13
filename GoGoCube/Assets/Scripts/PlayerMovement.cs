using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float speedMultiplier = 1f;
    public Material matPink;
    public Material matBlue;
    public Material matDefault;

    private int thing = 0;
    public int gateCheck 
    {
        get {return thing;}
        set 
        {
            thing = value;
            if(thing == -1)
                this.transform.gameObject.GetComponent<Renderer>().material = matBlue;
            if(thing == 1)
                this.transform.gameObject.GetComponent<Renderer>().material = matPink;
            if(thing == 0)
                this.transform.gameObject.GetComponent<Renderer>().material = matDefault;
        }
    }
    private float _pos;
    public float playerInput 
    {
        get {return _pos;}
        set
        {
            _pos = value;
            if( _pos > 2.5)
            {
                _pos = 2.5f;
            }
            if(_pos < -2.5)
            {
                _pos = -2.5f;
            }

            this.transform.position = new Vector3(_pos, transform.position.y, transform.position.z);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0,0,forwardForce * speedMultiplier * Time.fixedDeltaTime);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerInput += 2.5f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerInput -= 2.5f;
        }
        
        if (Input.GetKey(KeyCode.L))
            gateCheck = -1;
        else if(Input.GetKey(KeyCode.J))
            gateCheck = 1;
        else
            gateCheck = 0;
            
    }
}
