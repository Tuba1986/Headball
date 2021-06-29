using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float jump = 5f;
    public Animator anima;
    public bool isGrounded;
    public LayerMask groundLayers;
    private GameObject lopta;
    public bool shoot1;
    [SerializeField] float udaracX2 = 5f;
    [SerializeField] float udaracY2 = 10f;
    private bool isPlaying;

    private void Start()
    {
        anima = GetComponent<Animator>();
        Physics2D.IgnoreLayerCollision(9, 8, true);
        lopta = GameObject.FindGameObjectWithTag("lopta");
    }
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + moveSpeed, transform.position.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - moveSpeed, transform.position.y);
        }
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.41f, transform.position.y - 0.45f),
             new Vector2(transform.position.x + 0.41f, transform.position.y - 0.45f), groundLayers);
        Jump();
        Shoot1();

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            GetComponent<AudioSource>().Play();
        }
    }
  /*  private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.45f),
            new Vector2(1, 0.01f));
    }       */
    public void Shoot1()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anima.Play("pucanje2");
        }
        if (anima.GetCurrentAnimatorStateInfo(0).IsName("pucanje2") && shoot1 == true)
        {
            anima.Play("pucanje2");
            lopta.GetComponent<Rigidbody2D>().AddForce(new Vector2(udaracX2, udaracY2),ForceMode2D.Force);
            
        }
    }
}