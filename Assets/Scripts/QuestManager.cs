using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public StageUIManager stageUI;

    int currentStage = 1;

    void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    public void OnNextButton()
    {
        currentStage++;
        Debug.Log("進行度増加" + currentStage);

        stageUI.UpdateUI(currentStage);
    }
}
