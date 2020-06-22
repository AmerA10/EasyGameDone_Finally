using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class manageGame : MonoBehaviour
{
    // Start is called before the first frame update

    private static manageGame manageGameInstance;
    void Awake()
    {
       
        DontDestroyOnLoad(this.gameObject);
       
        if (manageGameInstance == null)
        {
            manageGameInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void loadGame()
    {
        SceneManager.LoadScene(0);
    }
    public  void loadMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void loadLoseMenu()
    {
        SceneManager.LoadScene(2);
    }
    
 
}
