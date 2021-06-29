using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaliGol : MonoBehaviour
{
    public GameObject lopta;
    public GameObject gol1;
    public GameObject gol2;
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
            gol1.transform.position = new Vector2(8.355f, -2.81f);
            gol1.transform.localScale = new Vector3(0.6885601f, 0.8060154f, 0.5738f);
            gameObject.transform.position = new Vector3(8.14f, -4.39f, 1f);


        }

        if (collision.gameObject.name == "lopta" && lopta.GetComponentInChildren<loptaTriger>().zadnjiIgrac2 == true)
        {
            
            gol2.transform.position = new Vector2(-8.363f, -2.81f);
            gol2.transform.localScale = new Vector3(0.6885601f, 0.8060154f, 0.5738f);
            gameObject.transform.position = new Vector3(-8.14f, -4.39f, 1f);


        }


    }
}
