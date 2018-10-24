using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

    public static PlayerJump instance;

    private Rigidbody2D myBody;

    private Animator anim;

    public float forceX;
    public float forceY;

    private float thresholdX = 7f;
    private float thresholdY = 14f;

    private bool canSetPower;
    private bool hasJumped;

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Awake()
    {
        MakeInstance();
        InitialisePlayerComps();
    }

    void InitialisePlayerComps()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void Set_CanSetPower(bool isPowerSet)
    {
        this.canSetPower = isPowerSet;

        if (!canSetPower)
        {
            Jump();
        }
    }

    void Jump()
    {
        myBody.velocity = new Vector2(forceX, forceY);

        forceX = 0f;
        forceY = 0f;

        hasJumped = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasJumped)
        {
            // Uhhh... what do here?
        }
    }

    void Update()
    {
        CalcPower();
    }

    void CalcPower()
    {
        if (canSetPower)
        {
            forceX = forceX + thresholdX * Time.deltaTime;
            forceY = forceY + thresholdY * Time.deltaTime;

            if(forceX > 6.5f)
            {
                forceX = 6.5f;
            }

            if(forceY > 13.5f)
            {
                forceY = 13.5f;
            }
        }
    }



}
