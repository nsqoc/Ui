using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
     public float horizontalMovements;
        public float verticalMovements;
    public float moveSpeed = 5f;
    private Rigidbody rg;
   

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
       


        horizontalMovements = Input.GetAxis("Horizontal");
        verticalMovements = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovements,  0.0f,verticalMovements );


        rg.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime);


    }
}
