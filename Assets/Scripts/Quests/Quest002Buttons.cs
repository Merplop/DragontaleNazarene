using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest002Buttons : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject UIQuest;
    public GameObject ActiveQuestBox;
    public GameObject Objective01;
    public GameObject Objective02;
    public GameObject Sign;
    public GameObject BulletinTrigger;
    public GameObject ActionDisplay;
    public GameObject ActionText;

    public void AcceptQuest()
    {
        QuestManager.SubQuestNumber = 1;
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        UIQuest.SetActive(false);
        Sign.SetActive(false);
        BulletinTrigger.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        StartCoroutine(SetQuestUI());
    }

    IEnumerator SetQuestUI()
    {
        ActiveQuestBox.GetComponent<Text>().text = "Sword of Dagon Runedweller";
        Objective01.GetComponent<Text>().text = "Travel to Bleakborne Cave";
        Objective02.GetComponent<Text>().text = "Retrieve the sword of Dagon Runedweller";
        QuestManager.ActiveQuestNumber = 1;
        yield return new WaitForSeconds(0.5f);
        ActiveQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        Objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective02.SetActive(true);
        yield return new WaitForSeconds(9);
        ActiveQuestBox.SetActive(false);
        Objective01.SetActive(false);
        Objective02.SetActive(false);
    }

    public void DeclineQuest()
    {
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        UIQuest.SetActive(false);

    }

}