using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Merplopscenes;

public class WorldToDungeon01 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ThePlayer;

    private void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

        private void OnMouseOver()
        {
            if (TheDistance <= 3)
            {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            ActionText.GetComponent<Text>().text = "Enter Helmfirth Dungeon";
        }

    if (Input.GetButtonDown("Action"))
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            SceneManager.LoadScene(Merplopscenes.Dungeon1);
        }
    }
}

void OnMouseExit()
{
    ActionDisplay.SetActive(false);
    ActionText.SetActive(false);
}

}