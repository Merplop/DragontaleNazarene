using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevelV2 : MonoBehaviour
{

    public GameObject enterText;

    void Start()
    {
        if (Input.GetButtonDown("Use"))
        {
            SceneManager.LoadScene(2);
        }
    }
}