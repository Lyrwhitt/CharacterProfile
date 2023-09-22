using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterStats : UIPopup
{
    public CharacterStats characterData;

    public Text characterAtkText;
    public Text characterDefText;
    public Text characterHpText;
    public Text characterCriText;
    public Button statsCloseBtn;

    private void OnEnable()
    {
        UpdateCharacterStats();
    }

    private void Start()
    {
        statsCloseBtn.onClick.AddListener(StatsCloseBtnClicked);
    }

    public void UpdateCharacterStats()
    {
        characterAtkText.text = (characterData.atk + characterData.GetEquipAtk()).ToString();
        characterDefText.text = (characterData.def + characterData.GetEquipDef()).ToString();
        characterHpText.text = characterData.hp.ToString();
        characterCriText.text = characterData.criticalRate.ToString();
    }

    public void StatsCloseBtnClicked()
    {
        UIManager.instance.ClosePopup();
    }
}
