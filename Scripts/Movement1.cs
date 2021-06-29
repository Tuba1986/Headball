using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float jump = 5f;
    public Animator anim;
    public bool isGrounded;
    public LayerMask groundLayers;
    private GameObject lopta;
    public bool shoot;
    [SerializeField] float udaracX = 5f;
    [SerializeField] float udaracY = 10f;

    private void Start()
    {
        anim = GetComponent<Animator>();
        Physics2D.IgnoreLayerCollision(9,8,true);
        lopta = GameObject.FindGameObjectWithTag("lopta");
    }
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + moveSpeed, transform.position.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - moveSpeed, transform.position.y);
        }
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.41f, transform.position.y - 0.45f),
            new Vector2(transform.position.x + 0.41f, transform.position.y - 0.45f), groundLayers);
        Shoot();
        Jump();
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            GetComponent<AudioSource>().Play();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.45f),
            new Vector2(1, 0.01f));
    }
   
    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.Play("pucanje1");
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("pucanje1") && shoot == true) 
        {
            anim.Play("pucanje1");
            lopta.GetComponent<Rigidbody2D>().AddForce(new Vector2(udaracX, udaracY), ForceMode2D.Force);
        }
    }
   

}