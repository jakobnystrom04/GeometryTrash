using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constantMoving : MonoBehaviour
{
    public float speed;
    // Detta gör så att du kan ställa in hastigheten objekten rör sig på i Unity. 
    private Rigidbody2D rb2d;
    // Detta gör så att jag kan skriva rb2d istället för Rigidbody2D

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        // Den hämtar Rigidbody2D ifrån objekten med skriptet.
        rb2d.AddForce(transform.right * -speed);
        // Den gör så att objekten rör sig åt vänster, kraften bestäms i Unity.
    }
}