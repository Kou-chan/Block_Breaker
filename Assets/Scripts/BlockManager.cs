using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    Transform mTransform;
    // Start is called before the first frame update
    void Start()
    {
        mTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(mTransform.childCount == 1)
        {
            GamePlayDirector.GameClear();
        }
    }
}
