using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerOfGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<LevelGenerator>().GenerateLevel("First_Level"); 
    }
}
