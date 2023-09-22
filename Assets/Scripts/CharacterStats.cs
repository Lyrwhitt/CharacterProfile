using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumManager;

[CreateAssetMenu(fileName ="CharacterStatData", menuName ="CharacterData", order = 0)]
public class CharacterStats : ScriptableObject
{
    public string id;
    public Sprite img;
    public int lv;
    public int gold;
    public float atk;
    public float def;
    [Range(0, 100)] public float hp;
    [Range(0, 100)] public float criticalRate;

    public List<EquipItemSO> equipedItems;

    public float GetEquipAtk()
    {
        float equipAtk = 0f;

        for(int i = 0; i < equipedItems.Count; i++)
        {
            EquipItemSO item = equipedItems[i];

            if(item.equipType == EquipType.Weapon)
            {
                equipAtk += item.power;
            }
        }

        return equipAtk;
    }

    public float GetEquipDef()
    {
        float equipDef = 0f;

        for (int i = 0; i < equipedItems.Count; i++)
        {
            EquipItemSO item = equipedItems[i];

            if (item.equipType == EquipType.Armor)
            {
                equipDef += item.power;
            }
        }

        return equipDef;
    }
}
