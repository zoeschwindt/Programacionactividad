using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameOver : MonoBehaviour
{
   
    [SerializeField] GameObject lose;


   void Start()
    {
       lose.SetActive(false);
    }

    public void ActiveScreenLose()
    {
        lose.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    

}

