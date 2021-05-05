using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipTrailer : MonoBehaviour
{
    [SerializeField] private string menuLevel;
    // En variabel så att jag kan ställa in vilken level som den ska byta till i Unity.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            // Ifall du trycker på space
        {
            SceneManager.LoadScene(menuLevel);
            // Den laddar in leveln som man bestämmer i Unity.
        }
    }
}
