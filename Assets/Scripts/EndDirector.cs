using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDirector : MonoBehaviour
{
    public void MoveHome()
    {
        SceneManager.LoadScene("start");
    }

    public void Retry()
    {
        SceneManager.LoadScene("play");
    }
}
