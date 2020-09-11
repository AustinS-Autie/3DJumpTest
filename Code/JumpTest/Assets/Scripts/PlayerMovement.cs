using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5;
    [SerializeField]
    float jumpSpeed = 10;
    [SerializeField]
    int jumpTimes = 1;      

    int jump = 0;

    int colDist = 2;


    Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, Vector3.down * colDist);

        Debug.DrawLine(r.origin, r.origin + (Vector3.down * colDist) );

        RaycastHit hit;
        
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        rBody.velocity = new Vector3(hAxis * moveSpeed, rBody.velocity.y, vAxis * moveSpeed);

        if(Input.GetButtonDown("Jump") && jump<jumpTimes)
        {
            Jump();
            jump += 1;
        }



        if (Physics.Raycast(r, out hit, colDist))
        {

            if (hit.transform.GetComponent<GroundInfo>() != null && rBody.velocity.y<=4)
            {
                jump = 0;

            }
        }
    }
    
    void Jump()
    {
        rBody.velocity = new Vector3(rBody.velocity.x, jumpSpeed, rBody.velocity.z);
    }
}
