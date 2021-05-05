using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jump : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private string nextLevel;
    [SerializeField] private string menuLevel;
    // Variabler för levlar så man kan bestämma vilka levlar som det byts till i Unity.
    Rigidbody2D rb;
    // Så att jag kan skriva rb istället för Rigidbody2D i skriptet.
    public float ufoForce;
    // Ett float för kraft som bestäms i Unity.
    public float padForce;
    // Ett float för kraft som bestäms i Unity.
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Den hämtar Rigidbody2D från objekt med skriptet.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            {
                UfoJump();
            }

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menuLevel);
        }


    }


    void OnTriggerEnter2D(Collider2D other)
    // Detta aktiveras ifall Boxcollider2D känner av ifall objektet kolliderar med ett annat objekt.
    {
        if (other.CompareTag("Player"))
        // Om objektet kolliderar med ett objekt med tagen Player
        {
            Orb();
            // Funktionen Orb() aktiveras
        }
        else if (other.CompareTag("Respawn"))
        // Om objektet kolliderar med ett objekt med tagen Respawn
        {
            SceneManager.LoadScene(newLevel);
            // Den byter till scenen som bestäms i Unity.
        }
        else if (other.CompareTag("Enemy"))
        // Om objektet kolliderar med ett objekt med tagen Enemy
        {
            SceneManager.LoadScene(nextLevel);
            // Den byter till scenen som bestäms i Unity.
        }
        else if (other.CompareTag("Finish"))
        // Om objektet kolliderar med ett objekt med tagen Finish
        {
            SceneManager.LoadScene(menuLevel);
            // Den byter till scenen som bestäms i Unity.
        }
    }


    void UfoJump()
    // Förklarar funktionen UfoJump()
    {
        rb.velocity = Vector2.up * ufoForce;
        // Den använder Rigidbody2D och sen använder variabeln för kraft i unity för att veta hur mycket uppåt den ska.
    }

    void Orb()
    // Förklarar funktionen Orb()
    {
        rb.velocity = Vector2.up * padForce;
        // Den använder Rigidbody2D och sen använder variabeln för kraft i unity för att veta hur mycket uppåt den ska.
    }

    
}
