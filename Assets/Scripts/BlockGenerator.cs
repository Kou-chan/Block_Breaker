using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    BlockManager parentObject;

    // Start is called before the first frame update
    void Start()
    {
        parentObject = FindObjectOfType<BlockManager>();
        GeneratorBlock();
    }

    void GeneratorBlock() 
    {
        for (int i = 0; i < 5; i++)
        { 
            for(int j = 0; j < 9; j++)
            {
                GameObject block = Instantiate(blockPrefab, parentObject.transform) as GameObject;
                block.transform.position = new Vector3(block.transform.position.x + 2 * j, block.transform.position.y - i, 0);
            }
        }
    }
}
