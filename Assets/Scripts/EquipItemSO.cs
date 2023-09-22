using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumManager;

[CreateAssetMenu(fileName = "DefaultEquipItemData", menuName = "ItemData", order = 0)]
public class EquipItemSO : ScriptableObject
{
    public int id;
    public float power;
    public int price;
    public string itemName;
    public string explanation;
    public Sprite img;
    public EquipType equipType;

    public bool isEquip = false;
}
