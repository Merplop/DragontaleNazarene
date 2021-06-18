using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Merplopscenes;

public class WorldToTavern : MonoBehaviour {

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
            ActionText.GetComponent<Text>().text = "Enter the Twilight Tavern";
        }

        if (Input.GetButtonDown("Action")) {
            if (TheDistance <= 3) {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            SceneManager.LoadScene(Merplopscenes.Tavern);
        }
    }
}

void OnMouseExit() {
    ActionDisplay.SetActive(false);
    ActionText.SetActive(false);
}

}