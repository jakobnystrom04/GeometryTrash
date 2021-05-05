using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneScript : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private string menuLevel;
    // Dessa gör så att jag kan ändra vilka levlar som ska startas i unity och därmed kan använda samma command på olika script.
    Rigidbody2D rb;
    // Det gör så att jag kan skriva rb istället för Rigidbody2D i spelet. 
    public float jumpForce;
    // Det gör så jag kan ändra kraften av hur mycket den åker uppåt i unity.
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Den checkar så att kuben har en Rigidbody2D

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        // Ifall du trycker space så aktiveras Jump() som förklaras längre ner.
        else
        {
            Fall();
        }
        // Ifall du inte trycker space så ska den åka ner med samma kraft som den åker upp om du trycker space.

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(menuLevel);
        }
        // Detta gör så att du när som helst kan gå till menyn.


    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    // Här förklaras funktionen Jump(), den använder sig av Rigidbody2D och med ett float så man kan bestämma kraften av hoppet i unity.

    void Fall()
    {
        rb.velocity = Vector2.down * jumpForce;
    }
    // Här förklaras funktionen Fall(), det är samma som Jump(), men den går neråt istället för uppåt.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(newLevel);
        }
        // Ifall kuben kolliderar med ett objekt med tagen Respawn så startas en ny level.
        
        else if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(menuLevel);
        }
        // Samma som ovan men med tagen Finish
    }
}
