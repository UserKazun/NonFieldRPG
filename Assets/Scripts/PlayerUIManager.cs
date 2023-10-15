using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    public Text hpText;
    public Text atText;
    
    public void SetupUI(PlayerManager player)
    {
        hpText.text = $"HP：{player.hp}";
        atText.text = $"HP：{player.at}";
    }

    public void UpdateUI(PlayerManager player)
    {
        var playerHp = player.hp;
        hpText.text = $"HP：{playerHp}";
    }
}
