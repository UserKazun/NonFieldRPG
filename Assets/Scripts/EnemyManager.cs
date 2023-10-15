using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private Action _tapAction;
    
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

        if (hp <= 0)
        {
            hp = 0;
        }
    }

    public void AddEventListenerOnTap(Action action)
    {
        _tapAction += action;
    }

    public void OnTap()
    {
        Debug.Log("clicked enemy");
        _tapAction();
    }
}
