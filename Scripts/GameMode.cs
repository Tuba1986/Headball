using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMode : MonoBehaviour
{
   public void OneMinute()
    {
        SceneManager.LoadScene(2);

    }
    public void FirstToSeven()
    {
        SceneManager.LoadScene(1);
    }
}
