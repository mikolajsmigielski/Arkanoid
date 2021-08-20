using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerOfGame : MonoBehaviour
{
    string LevelName;
    // Start is called before the first frame update
    void Start()
    {
        LevelName = PlayerPrefs.GetString("CurrentLevel");
        GenerateLevel();
        StartCoroutine(LevelEndCorutine());
    }
    void GenerateLevel()
    {
        FindObjectOfType<LevelGenerator>().GenerateLevel(LevelName);
    }
    IEnumerator LevelEndCorutine()
    {
        while (true)
        {
            if (CheckIfLevelEnd())
                ChangeScene();
            yield return new WaitForSeconds(1f);
        }
        
    }
    bool CheckIfLevelEnd()
    {
        return FindObjectsOfType<Block>().Length == 0;
        
    }
    void ChangeScene()
    {
        PlayerPrefs.SetInt(LevelName + "_finished", 1);
        SceneManager.LoadScene("Menu");
    }
}
