using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 60;
    [SerializeField] TextMeshProUGUI timer;

    private void Start()
    {
  
    }

    void Update()
    {
        Debug.Log(time);
        timer.text = Mathf.Round(time).ToString();
        if (time > 0)
            {
                time -= Time.deltaTime;
            }   
     }
    
}

