using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbtn : MonoBehaviour
{
    
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
