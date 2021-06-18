using System.Collections;
using System.Collections.Generic;
using System.Media;
using System.Security.Cryptography;
using UnityEngine;

public class SaveLocation : MonoBehaviour
{

    //position
    public float CharacterPosX;
    public float CharacterPosY;
    public float CharacterPosZ;

    //rotation
    public float CharacterRotX;
    public float CharacterRotY;
    public float CharacterRotZ;

    //getting values for current pos/rot
    public void Awake()
    {
        CharacterPosX = PlayerPrefs.GetFloat("MyPositionX");
        CharacterPosY = PlayerPrefs.GetFloat("MyPositionY");
        CharacterPosZ = PlayerPrefs.GetFloat("MyPositionZ");

        CharacterRotX = PlayerPrefs.GetFloat("MyRotationX");
        CharacterRotY = PlayerPrefs.GetFloat("MyRotationY");
        CharacterRotZ = PlayerPrefs.GetFloat("MyRotationZ");
    }

    //setting values for current pos/rot
    public void Start()
    {

    }

    //saving values of current pos/rot every frame
    public void Update()
    {
        PlayerPrefs.SetFloat("MyPositionX", transform.position.x);
        PlayerPrefs.SetFloat("MyPositionY", transform.position.y);
        PlayerPrefs.SetFloat("MyPositionZ", transform.position.z);

        PlayerPrefs.SetFloat("MyRotationX", transform.eulerAngles.x);
        PlayerPrefs.SetFloat("MyRotationY", transform.eulerAngles.y);
        PlayerPrefs.SetFloat("MyRotationZ", transform.eulerAngles.z);


    }


}
