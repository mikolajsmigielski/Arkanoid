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
        var finished = PlayerPrefs.GetInt(LevelName + "_finished", 0) != 0;
        GetComponent<Image>().color = finished ? Color.green : Color.white;
        GetComponentInChildren<Text>().text = LevelName;
        GetComponent<Button>().onClick.AddListener(ChangeScene);
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetString("CurrentLevel", LevelName);
    }
    
}
