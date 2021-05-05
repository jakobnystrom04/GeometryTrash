using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    [SerializeField] private string Level1;
    [SerializeField] private string Level2;
    [SerializeField] private string Level3;
    // Med dessa kan jag i unity bestämma vilken scen som ska laddas.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loadscene()
    {
        SceneManager.LoadScene(Level1);
    }
    public void Loadscene2()
    {
        SceneManager.LoadScene(Level2);
    }
    public void Loadscene3()
    {
        SceneManager.LoadScene(Level3);
    }
    // De laddar scenerna som bestäms i unity, jag använder private string för att kunna ändra saker senare utan att ändra i skriptet.
}
