using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour
{

    public bool invOpen = false;                // Boolean invOpen set to false by default
    public GameObject invMenu;
    public GameObject thePlayer;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))      // Calls cancel command
        {
            if(invOpen = false)
            {
                Time.timeScale = 0;                 // Pauses game
                invOpen = true;                     // Activates invOpen boolean
                Cursor.visible = true;              // Activates mouse cursor
                invMenu.SetActive(true);            // Shows menu
                thePlayer.GetComponent<FirstPersonController>().enabled = false;    // Deactivates FPS controller
            }
            else
            {
                thePlayer.GetComponent<FirstPersonController>().enabled = true;     // Reactivates FPS controller
                invMenu.SetActive(false);                                           // Hides menu
                Cursor.visible = false;                                             // Deactivates mouse cursor
                invOpen = false;                                                    // Deactivates invOpen boolean
                Time.timeScale = 1;                                                 // Turns time scale back on
            }
        }
    }
}
