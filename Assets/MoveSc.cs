using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movesc : MonoBehaviour
{
    [SerializeField] private string newLevel;
    // Variabel för en scen i unity.

    void OnTriggerEnter2D(Collider2D other)
    // Ifall kolliderande objekt har tagen finish, så laddas en scen.
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }
}
