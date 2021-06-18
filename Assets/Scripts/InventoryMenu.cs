using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour
{

    public bool invOpen = false;
    public GameObject invMenu;
    public GameObject thePlayer;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(invOpen = false)
            {
                Time.timeScale = 0;
                invOpen = true;
                Cursor.visible = true;
                invMenu.SetActive(true);
                thePlayer.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                thePlayer.GetComponent<FirstPersonController>().enabled = true;
                invMenu.SetActive(false);
                Cursor.visible = false;
                invOpen = false;
                Time.timeScale = 1;
            }
        }
    }
}
