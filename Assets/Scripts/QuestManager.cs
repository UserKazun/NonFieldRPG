using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public StageUIManager stageUI;
    public GameObject enemyPrefab;

    // 1 is enemy encount, 0 is enemy not encount
    readonly int[] encountTable = { 1, 0, 1, 1, 0, 1 };

    int currentStage = 0;

    void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    public void OnNextButton()
    {
        currentStage++;
        stageUI.UpdateUI(currentStage);

        if (encountTable.Length <= currentStage)
        {
            Debug.Log("Complete Quest!!");
        }
        else if (encountTable[currentStage] == 1)
        {
            EncountEnemy();
        }
    }

    void EncountEnemy()
    {
        stageUI.ShowHideSwitchButton(false);
        Instantiate(enemyPrefab);
    }
}
