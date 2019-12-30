using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float baseSpeed = 10;
    [SerializeField] Rigidbody rb;
    float speed;
    public float sprintMultiplier = 2;

    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = baseSpeed * sprintMultiplier;
        }
        else
        {
            speed = baseSpeed;
        }

        direction = transform.right * x + transform.forward * z;
        direction = direction.normalized;
        // this.gameObject.transform.position += (this.direction * Time.deltaTime) * speed;
        //Debug.Log(direction);

        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
