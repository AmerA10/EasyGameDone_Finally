using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFIeld : MonoBehaviour
{
    // Start is called before the first frame update
    public manageGame manageGameInstance;
    GameObject manageGameObject;

     void Awake()
    {
        manageGameObject = GameObject.FindGameObjectWithTag("gameManager");
        if (manageGameObject != null)
        {
            manageGameInstance = manageGameObject.GetComponent<manageGame>();
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       
        
            Debug.Log("You lost the game");
            manageGameInstance.loadLoseMenu();
        
    }
}
