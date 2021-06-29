using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelikiSkok : MonoBehaviour
{
    public GameObject lopta;
    public GameObject igrac1;
    public GameObject igrac2;
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
        if (collision.gameObject.name == "lopta" && lopta.GetComponentInChildren<loptaTriger>().zadnjiIgrac1 == true)
        {
            igrac1.GetComponent<Movement1>().jump = 31f;
            gameObject.transform.position = new Vector3(8.14f, -4.39f, 1f);
        }
        if (collision.gameObject.name == "lopta" && lopta.GetComponentInChildren<loptaTriger>().zadnjiIgrac2 == true)
        {
            igrac2.GetComponent<Movement2>().jump = 31f;
            gameObject.transform.position = new Vector3(-8.14f, -4.39f, 1f);
        }
    }
}
