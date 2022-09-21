using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayDirector : MonoBehaviour
{

    Transform mTransform;
    public static bool isClear;
    // Start is called before the first frame update
    void Start()
    {
        mTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void GameClear()
    {
        isClear = true;
        SceneManager.LoadScene("end");
    }

    public static void GameOver()
    {
        isClear = false;
        SceneManager.LoadScene("end");
    }
}
