using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private string nextLevel;
    [SerializeField] private string menuLevel;
    // Detta gör att du kan ställa in vilka levlar som det ska bytas till i Unity.
    void OnTriggerEnter2D(Collider2D other)
    // Den aktiveras när Box Collider 2D känner av ett annat objekt.
    {
        if (other.CompareTag("Respawn"))
        // Ifall ett objekt har tagen respawn
        {
            SceneManager.LoadScene(newLevel);
            // Den laddar in leveln som bestäms i Unity.
        }
        else if (other.CompareTag("Enemy"))
        // Ifall ett objekt har tagen Enemy
        {
            SceneManager.LoadScene(nextLevel);
            // Den laddar in leveln som bestäms i Unity.
        }
        else if (other.CompareTag("Finish"))
        // Ifall ett objekt har tagen Finish
        {
            SceneManager.LoadScene(menuLevel);
            // Den laddar in leveln som bestäms i Unity.
        }

    }
}
