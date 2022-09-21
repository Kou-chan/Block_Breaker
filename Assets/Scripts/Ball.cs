using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //ボールの速さの指定
    const float speed = 10f;
    Rigidbody2D mRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
        mRigidbody.velocity = new Vector2(speed * Random.Range(-1.0f, 1.0f), speed * -1);

    }
}
