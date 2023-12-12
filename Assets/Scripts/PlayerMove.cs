using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public AudioSource move,jump;
    private Rigidbody2D rd;
    private Animator ani;
    private BoxCollider2D coll;
    private SpriteRenderer str;
    public LayerMask ground;
    private float moveSpeed = 9f;
    private float jump1 = 14f;
    private float dirX = 0;
    float changeTime;
    float timeValue = 3.0f;
    bool setTime;
    private enum MovementState { idel, running, jumping ,falling};
    public UIhealth health;
    
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
        str = GetComponent<SpriteRenderer>();
        currenthealth = 50;
        health.maxhealth(maxhealth);
        health.currenthealth(currenthealth);
        changeTime = timeValue;
    }
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rd.velocity = new Vector2(dirX * moveSpeed, rd.velocity.y);
        if (Input.GetButtonDown("Jump") && IsGround())
        {
            jump.Play();
            rd.velocity = new Vector2(rd.velocity.x, jump1);
        }
        UpdateAnimation();
        health.currenthealth(currenthealth);
        if (changeTime > 0)
        {
            changeTime-=Time.deltaTime;
            if (changeTime < 0)
            {
                setTime = true;
            }
        }
    }
    public void UpdateAnimation()
    {
        MovementState state;
        if (dirX > 0f)
        {
            state = MovementState.running;
            str.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            str.flipX = true;
        }
        else
        {
            state = MovementState.idel;
        }


        if (rd.velocity.y > .1f)
        {
            state = MovementState.jumping;
            
        }
        else if (rd.velocity.y < -.1f)
        {
            state = MovementState.falling;
           
        }
        
        ani.SetInteger("state", (int)state);
    }
    private bool IsGround()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, ground);
    }
    public void changehealth(int a)
    {
        if (a < 0)
        {
            if (setTime)
            {
                currenthealth += a;
                changeTime = timeValue;
                setTime = false;
            }
        }
        else
        {
            currenthealth += a;
        }
    }
}
