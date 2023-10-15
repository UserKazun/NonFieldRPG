using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public PlayerUIManager playerUI;
    public EnemyUIManager enemyUI;

    public PlayerManager player;
    public EnemyManager enemy;

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        enemyUI.SetupUI(enemy);
        playerUI.SetupUI(player);
    }

    void PlayerAttack()
    {
        player.Attack(enemy);
        enemyUI.UpdateUI(enemy);
    }

    void EnemyAttack()
    {
        enemy.Attack(player);
        playerUI.UpdateUI(player);
    }
}
