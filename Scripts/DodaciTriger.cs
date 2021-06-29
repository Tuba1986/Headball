using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodaciTriger : MonoBehaviour
{
    private GameObject lopta;
    public GameObject gol1;
    public GameObject gol2;
    public PhysicsMaterial2D normal;
    public GameObject kopacka1;
    public GameObject kopacka2;
    public GameObject igrac1;
    public GameObject igrac2;

    // Start is called before the first frame update
    void Start()
    {
        lopta = GameObject.FindGameObjectWithTag("lopta");
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "lopta") 
        {
            StartCoroutine(Normal());
        } 

    }
    public IEnumerator Normal()
    {
        yield return new WaitForSeconds(10);
        //brza lopta
        lopta.GetComponent<Renderer>().material.color = Color.white;
        lopta.GetComponent<Rigidbody2D>().sharedMaterial = normal;
        Destroy(gameObject);
        //veliki gol
        gol2.transform.position = new Vector2(-8.363f, -2.2039f);
        gol2.transform.localScale = new Vector2(1.2f, 1.41204f);
        gol1.transform.position = new Vector2(8.355f, -2.2039f);
        gol1.transform.localScale = new Vector2(1.2f, 1.41204f);
        Destroy(gameObject);
        //nemaPucanja
        kopacka1.SetActive(true);
        kopacka2.SetActive(true);
        Destroy(gameObject);
        //VelikiSkok
        igrac1.GetComponent<Movement1>().jump = 26f;
        igrac2.GetComponent<Movement2>().jump = 26f;
        Destroy(gameObject);
        //NemaKretanja
        igrac1.GetComponent<Movement1>().moveSpeed = 0.1f;
        igrac2.GetComponent<Movement2>().moveSpeed = 0.1f;
        Destroy(gameObject);
        //NemaSkakanja
        igrac1.GetComponent<Movement1>().jump = 26f;
        igrac2.GetComponent<Movement2>().jump = 26f;
        Destroy(gameObject);

    }
}
