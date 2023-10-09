using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1_Velocidad : MonoBehaviour
{

    private Rigidbody rb;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = velocity;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(rb.velocity.x * horizontalInput, rb.velocity.y * verticalInput, 0);

        if(Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Pressed key: DOWN");
            Debug.Log("Velocity result: (" + rb.velocity.x + "," + rb.velocity.y + "," + rb.velocity.z + ")");
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Pressed key: UP");
            Debug.Log("Velocity result: (" + rb.velocity.x + "," + rb.velocity.y + "," + rb.velocity.z + ")");
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Pressed key: RIGHT");
            Debug.Log("Velocity result: (" + rb.velocity.x + "," + rb.velocity.y + "," + rb.velocity.z + ")");
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Pressed key: LEFT");
            Debug.Log("Velocity result: (" + rb.velocity.x + "," + rb.velocity.y + "," + rb.velocity.z + ")");
        }
    }
}
