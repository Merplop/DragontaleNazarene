﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPos : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Saved") == 1 && PlayerPrefs.GetInt("TimeToLoad") == 1)
        {
            float pX = player.transform.position.x;
            float pY = player.transform.position.y;
            float pZ = player.transform.position.z;

            pX = PlayerPrefs.GetFloat("p_x");
            pY = PlayerPrefs.GetFloat("p_y");
            pZ = PlayerPrefs.GetFloat("p_z");
            PlayerPrefs.SetInt("TimeToLoad", 0);
            PlayerPrefs.Save();
        }
    }

    public void PlayerPosSave()
    {
        PlayerPrefs.SetFloat("p_x", player.transform.position.x);
        PlayerPrefs.SetFloat("p_y", player.transform.position.y);
        PlayerPrefs.SetFloat("p_z", player.transform.position.z);
        PlayerPrefs.SetInt("Saved", 1);
        PlayerPrefs.Save();
    }

    public void PlayerPosLoad()
    {
        PlayerPrefs.SetInt("TimeToLoad", 1);
        PlayerPrefs.Save();
    }
}
