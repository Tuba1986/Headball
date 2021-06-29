using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brzaLopta : MonoBehaviour
{
    public SpriteRenderer sprite;
    public GameObject lopta;
    public Color color;
    public PhysicsMaterial2D normal;
    public PhysicsMaterial2D brzi;
    private void Start()
    {
        lopta = GameObject.FindGameObjectWithTag("lopta");
        color = new Color(252f, 0f,255f);
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "lopta")
        {
            lopta.GetComponent<Renderer>().material.color = color;
            lopta.GetComponent<Rigidbody2D>().sharedMaterial = brzi;
            Destroy(gameObject);

        }
    }


}

