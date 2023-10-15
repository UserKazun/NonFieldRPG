using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public QuestManager questManager;
    
    public PlayerUIManager playerUI;
    public EnemyUIManager enemyUI;

    public PlayerManager player;
    public EnemyManager enemy;

    private void Start()
    {
        enemyUI.gameObject.SetActive(false);
    }

    public void Setup(EnemyManager enemyManager)
    {
        enemyUI.gameObject.SetActive(true);
        
        enemy = enemyManager;
        enemyUI.SetupUI(enemy);
        playerUI.SetupUI(player);
        
        enemy.AddEventListenerOnTap(PlayerAttack);
    }

    private void PlayerAttack()
    {
        player.Attack(enemy);
        enemyUI.UpdateUI(enemy);

        if (enemy.hp == 0)
        {
            Destroy(enemy.gameObject);
            EndBattle();
            enemyUI.gameObject.SetActive(false);
        }
        else
        {
            EnemyTurn();
        }
    }

    private void EnemyTurn()
    {
        enemy.Attack(player);
        playerUI.UpdateUI(player);
    }

    private void EndBattle()
    {
        Debug.Log("end battle");
        questManager.EndBattle();
    }
}
