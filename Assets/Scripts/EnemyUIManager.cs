using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUIManager : MonoBehaviour
{
    public Text hpText;
    public Text nameText;

    public void SetupUI(EnemyManager enemy)
    {
        var enemyHp = enemy.hp;
        hpText.text = $"HP：{enemyHp}";
    }

    public void UpdateUI(EnemyManager enemy)
    {
        var enemyHp = enemy.hp;
        hpText.text = $"HP：{enemyHp}";
    }
}
