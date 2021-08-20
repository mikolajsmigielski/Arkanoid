using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject BlockPrefab;
    void Start()
    {
        
        LoadLevel("First_Level");
    }
    void LoadLevel(string name)
    {
        var path = "Assets/Levels/" + name + ".txt";
        var text = AssetDatabase.LoadAssetAtPath<TextAsset>(path).text;
        var lines = Regex.Split(text, System.Environment.NewLine);
        GenerateLevel(lines);
     }
    void GenerateLevel(string[] text)
    {
        var height = text.Length;
        var width = text[0].Length;

        for(int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var character = text[y][x];
                if (character == '_')
                    continue;

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
