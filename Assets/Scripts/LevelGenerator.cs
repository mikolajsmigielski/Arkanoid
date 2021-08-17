using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject BlockPrefab;
    void Start()
    {
        GenerateLevel(5, 3);
    }

    void GenerateLevel(int width, int height)
    {
        for(int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var position = new Vector2(x - width / 2, - y + height / 2);
                GenerateBlock(position);
            }
        }
    }
    void GenerateBlock(Vector2 position)
    {
        var block = Instantiate(BlockPrefab);

        block.transform.parent = transform;
        block.transform.localPosition = position;
    }
    
}
