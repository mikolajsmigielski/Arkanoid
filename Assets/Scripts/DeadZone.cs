using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class DeadZone : MonoBehaviour
{
    [SerializeField]
    string LevelName = "Menu";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>() == null) return;
        SceneManager.LoadScene(LevelName);
    }
}
