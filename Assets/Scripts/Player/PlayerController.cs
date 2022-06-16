using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public static Vector3 playerPos;

    // Update is called once per frame
    void Update()
    {
        playerPos = this.transform.position; //sets playerPos to this objects transform position

        Move();
    }

    private void Move()
    {
        Vector2 moveDir = Vector2.zero;
        moveDir.x += Input.GetAxisRaw("Horizontal"); //adds Horizontal input axis to moveDir
        moveDir.y += Input.GetAxisRaw("Vertical"); //adds Vertical input axis to moveDir
        moveDir.Normalize(); //normalizes moveDir
        transform.position += (Vector3)moveDir; //adds moveDir to transform position
    }
}
