using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loptaTriger : MonoBehaviour
{
    public bool zadnjiIgrac1 = false;
    public bool zadnjiIgrac2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "igrac1" ^ collision.gameObject.tag == "kopacka1")
        {
            zadnjiIgrac1 = true;
            zadnjiIgrac2 = false;
        }

        if (collision.gameObject.tag == "igrac2" ^ collision.gameObject.tag == "kopacka2")
        {    
            zadnjiIgrac2 = true;
            zadnjiIgrac1 = false;
        }
    }
 
}
