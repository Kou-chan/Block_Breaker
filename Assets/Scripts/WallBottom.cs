using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBottom : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {
        GamePlayDirector.GameOver();
    }
}
