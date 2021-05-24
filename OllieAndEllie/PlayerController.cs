using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName;
    public float speed = 5.0f;
    public float walkSpeed = 5.0f;
    public float runSpeed = 8.0f;
    public Animator anim;
    public Rigidbody rb;
    public bool turn;

    private float hInput;
    private float vInput;

    public float maxHP = 20;
    public float currentHP = 20;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (turn)
            GameObject.Find("PlayerHealth").GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " + currentHP + " / " + maxHP;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            turn = !turn;
            if(turn)
                GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameController>().turn = playerName;
        }



        if (turn)
        {
            hInput = Input.GetAxis("Horizontal");
            vInput = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("running", true);
                speed = runSpeed;
            }

            else
            {
                anim.SetBool("running", false);
                speed = walkSpeed;
            }

            if (Input.GetKeyDown(KeyCode.Space))
                anim.SetBool("attacking", true);
            else
                anim.SetBool("attacking", false);

            anim.SetFloat("speed", Mathf.Abs(hInput) + Mathf.Abs(vInput));

            if (hInput > 0)
                transform.eulerAngles = new Vector3(0.0f, 90.0f, 0.0f);
            else if (hInput < 0)
                transform.eulerAngles = new Vector3(0.0f, -90.0f, 0.0f);
            else if (vInput > 0)
                transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            else if (vInput < 0)
                transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);

        }
        else
        {
            hInput = 0.0f;
            vInput = 0.0f;
            anim.SetFloat("speed", 0.0f);
            anim.SetBool("running", false);
            anim.SetBool("attacking", false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(hInput*speed, 0.0f, vInput * speed);


    }
}
