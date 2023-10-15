using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public string monsterName;
    public int hp;
    public int at;

    public void Attack(PlayerManager player)
    {
        player.Damage(at);
    }

    public void Damage(int damage)
    {
        hp -= damage;
    }

    public void OnTap()
    {
        Debug.Log("clicked enemy");
    }
}
