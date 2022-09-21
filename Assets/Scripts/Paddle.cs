using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    const float speed = 15f;
    Rigidbody2D mRigidbody;
    AudioSource mAudioSource;
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
        mAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        mRigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            mAudioSource.PlayOneShot(se);
        }
    }
}
