using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Masterscript : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private string nextLevel;
    [SerializeField] private string menuLevel;
    // Levlarna som ska laddas, detta gör så att jag kan ändra de i unity istället för i skriptet.
    Rigidbody2D rb;
    //Förkortar hur jag skriver Rigidbody2D i skriptet.
    public float jumpForce;
    //Kraften man hoppar i, bestäms i unity.
    public float padForce;
    //Kraften padsen skickar dig, bestäms i unity.
    bool isGrounded;
    // Variabel som kommer vara falsk eller sann, den säger om du nuddar marken.
    public Transform groundCheck;
    // Relaterar till ett objekt i unity, den kommer kolla ifall du nuddar marken.
    public LayerMask groundlayer;
    // Den kollar om layer som du är på är marken.
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Gör så man kan skriva rb istället för Rigidbody2D.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }

        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(menuLevel);
        }


    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Orb();
        }
        else if (other.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(newLevel);
        }
        else if (other.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(nextLevel);
        }
        else if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(menuLevel);
        }
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Orb"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Orb();
            }
        }
        
    }


    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void Orb()
    {
        rb.velocity = Vector2.up * padForce;
    }

   
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
}
