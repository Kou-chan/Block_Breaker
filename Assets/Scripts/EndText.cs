using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text mText = GetComponent<Text>();
        if (GamePlayDirector.isClear == false)
        {
            mText.text = "Game Over";
        }
        else
        {
            mText.text = "Game Clear";
        }
    }
}
