using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    [SerializeField]
    string LevelName;
    
    void Start()
    {
        GetComponentInChildren<Text>().text = LevelName;
        GetComponent<Button>().onClick.AddListener(ChangeScene);
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetString("CurrentLevel", LevelName);
    }
    
}
