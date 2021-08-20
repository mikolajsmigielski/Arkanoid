using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerOfGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<LevelGenerator>().GenerateLevel("First_Level");
        StartCoroutine(CheckIfLevelEndCorutine());
    }
    IEnumerator CheckIfLevelEndCorutine()
    {
        while (true)
        {
            CheckIfLevelEnd();
            yield return new WaitForSeconds(1f);
        }
        
    }
    void CheckIfLevelEnd()
    {
        var numberOfBlocks = FindObjectsOfType<Block>().Length;
        if (numberOfBlocks == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
