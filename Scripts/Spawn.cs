using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] dodaci;
    private float osX;
    private float osY;

    Vector2 osXosY;
    
    private void Start()
    {
        InvokeRepeating("Spawnn", 5f, 17f);  
    }
   private void Spawnn()
    {
        osX = Random.Range(-7, 6.5f);
        osY = Random.Range(3.5f, 0);
        osXosY = new Vector2(osX,osY);
        int randomBroj = Random.Range(0, 7);
        GameObject noviObject = Instantiate(dodaci[randomBroj], osXosY, Quaternion.identity) as GameObject;
        GameObject triger = Instantiate(dodaci[7], osXosY, Quaternion.identity) as GameObject;
        noviObject.SetActive(true);
        GetComponent<AudioSource>().Play();
        triger.SetActive(true);
        Destroy(noviObject, 10f);
    }

}
