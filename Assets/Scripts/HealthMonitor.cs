using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour {

    public static int HealthValue;
    public int InternalHealth;
    public GameObject Health1;      // Defines health bar objects
    public GameObject Health2;
    public GameObject Health3;


    void Start() {                  // Run when script first starts
        HealthValue = 1;            // Defines health value of player during first log on
    }

    void Update() {                         // Run continuously
        InternalHealth = HealthValue;

        if (HealthValue == 1) {
            Health1.SetActive(true);        // Activates first health interval if health is 1 
        }
        if (HealthValue == 2) {
            Health2.SetActive(true);        // Activates second health interval if health is 2
        }
        if (HealthValue == 3) {
            Health3.SetActive(true);        // Activates third health interval if health is 3
        }

    }

}
