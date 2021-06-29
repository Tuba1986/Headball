using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemaPucanja : MonoBehaviour
{
    public GameObject lopta;
    public GameObject kopacka1;
    public GameObject kopacka2;
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
            kopacka2.SetActive(false);
            gameObject.transform.position = new Vector3(-8.14f, -4.39f, 1f);
            
        }
        if (collision.gameObject.name == "lopta" && lopta.GetComponentInChildren<loptaTriger>().zadnjiIgrac2 == true)
        {        
            kopacka1.SetActive(false);
            gameObject.transform.position = new Vector3(8.14f, -4.39f, 1f);

        }
    }
}
