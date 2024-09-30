using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    [SerializeField] SpriteRenderer spriteRenderer;

    private bool canMove = true;
    private Rigidbody2D rb;
    Vector2 movement;
    bool isRunning = false;
    bool isFacingRight = true;

    //[SerializeField] Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!canMove)
        {
            movement.x = 0;
            movement.y = 0;
            return;
        }
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift)) isRunning = true;
        else isRunning = false;
    }

    private void FixedUpdate()
    {
        if (isRunning)
        {
            rb.MovePosition(rb.position + (speed * 1.5f) * Time.fixedDeltaTime * movement);
        }
        else
        {
            rb.MovePosition(rb.position + speed * Time.fixedDeltaTime * movement);
            //anim.SetBool("isMoving", true);
            //anim.SetBool("isRunning", false);
        }

        //if (movement.x == 0 && movement.y == 0) anim.SetBool("isMoving", false);

        if (movement.x > 0 && !isFacingRight) { Flip(); Debug.Log("Left"); }
        else if (movement.x < 0 && isFacingRight) { Flip(); Debug.Log("Right"); }
    }

    public void SetCanMove(bool canMove)
    {
        this.canMove = canMove;
    }

    public bool GetCanMove()
    {
        return canMove;
    }

    void Flip()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;

        isFacingRight = !isFacingRight;
    }
}
