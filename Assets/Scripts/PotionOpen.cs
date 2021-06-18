using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionOpen : MonoBehaviour {

    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject HealthPotion;

    void Update() {
        RotateSpeed = 3;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter() {
        CollectSound.Play();
        HealthMonitor.HealthValue += 1;
        HealthPotion.SetActive(false);

    }
}

