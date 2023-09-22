using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainUIView : MonoBehaviour
{
    [Header("PlayerData")]
    public CharacterStats characterData;

    [Header("Character")]
    public Text characterIDText;
    public Text characterLVText;
    public Image characterImg;
    public Text characterGoldText;


    private void Start()
    {
        UpdateCharacterData();
    }

    public void UpdateCharacterData()
    {
        characterIDText.text = characterData.id;
        characterLVText.text = characterData.lv.ToString();
        characterImg.sprite = characterData.img;
        characterGoldText.text = characterData.gold.ToString();
    }
}
