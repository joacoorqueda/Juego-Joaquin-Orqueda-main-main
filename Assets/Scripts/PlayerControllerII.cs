using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerII : MonoBehaviour

{
    public float MovementSpeed;
    public float RotationSpeed;
    Rigidbody RB;
    bool Jump = false;
    public float JF;
    bool FD = false;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, MovementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -MovementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }



        Jump = Input.GetButtonDown("Jump");

        if (Jump && FD)
        {
            RB.AddForce(new Vector3(0, JF, 0), ForceMode.Impulse);
        }

        Vector3 Floor = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, Floor, 1.03f))
        {
            FD = true;
        }

        else
        {
            FD = false;
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "DeathFloor")
        {
            Destroy(gameObject);
        }

        else if (other.gameObject.name == "DeathFloor (1)")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "DeathFloor (2)")
        {
            Destroy(gameObject);
        }

    }


    
}