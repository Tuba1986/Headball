using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoptaGolden : MonoBehaviour
{
    private GameObject igrac1;
    private GameObject igrac2;
    public bool isGol1;
    public bool isGol2;
    [SerializeField] static int rez2 = 0;
    [SerializeField] static int rez1 = 0;
    [SerializeField] TextMeshProUGUI rezultat1;
    [SerializeField] TextMeshProUGUI rezultat2;
    public GameObject igrac2Win;
    public GameObject igrac1Win;
    private bool goalScored = false;
    public AudioClip goal;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Physics2D.IgnoreLayerCollision(10, 11);
        igrac1 = GameObject.FindGameObjectWithTag("igrac1");
        igrac2 = GameObject.FindGameObjectWithTag("igrac2");
        rezultat1.text = rez1.ToString();
        rezultat2.text = rez2.ToString();
        
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0 && (goalScored = true))
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
                rez1 = 0;
                rez2 = 0;
                igrac1Win.SetActive(false);
                igrac2Win.SetActive(false);

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kopacka1")
        {
            igrac1.GetComponent<Movement1>().shoot = true;
        }
        if (collision.gameObject.tag == "kopacka2") {
            igrac2.GetComponent<Movement2>().shoot1 = true;
        }
        if(collision.gameObject.tag == "gol1Triger")
        {
            GetComponent<AudioSource>().PlayOneShot(goal);
            goalScored = true;
            rez1 = rez1 + 1;
            rezultat1.text = rez1.ToString();
            igrac2Win.SetActive(true);
            Time.timeScale = 0;

        }
        if (collision.gameObject.tag == "gol2Triger")
        {
            GetComponent<AudioSource>().PlayOneShot(goal);
            goalScored = true;
            rez1 = rez1 + 1;
            rezultat2.text = rez2.ToString();
            igrac1Win.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kopacka1")
        {
            igrac1.GetComponent<Movement1>().shoot = false;
        }
        if (collision.gameObject.tag == "kopacka2") 
        { 
            igrac2.GetComponent<Movement2>().shoot1 = false;
        }
       
    }
   
}
   

