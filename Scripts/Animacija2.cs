using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacija2 : MonoBehaviour
{
    public Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot1();
    }
    public void Shoot1()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anima.Play("pucanje2");
        }
    }
}
