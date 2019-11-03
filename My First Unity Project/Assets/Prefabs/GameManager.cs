using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Rigidbody rb;
    public float restartDelay = 1f;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
  
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
