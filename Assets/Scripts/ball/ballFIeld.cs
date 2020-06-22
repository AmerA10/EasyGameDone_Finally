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
    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.enabled && collision.tag.Equals("Ball"))
        {
          
           
            manageGameInstance.loadLoseMenu();
        }
    }
     
        
    
}
