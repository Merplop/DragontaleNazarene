using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    public GameObject MainMark;
    public GameObject Objective01Mark;
    public static int SubQuestNumber;
    public int InternalSubNumber;
    public GameObject Pointer;

    void Update() {
        InternalQuestNumber = ActiveQuestNumber;
        InternalSubNumber = SubQuestNumber;
        Pointer.transform.LookAt(MainMark.transform);

        if (InternalSubNumber == 0)
        {
            Pointer.SetActive(false);
        }
        else
        {
            Pointer.SetActive(true);
        }

        if (InternalSubNumber == 1)
        {
            MainMark.transform.position = Objective01Mark.transform.position;
        }
    }

}