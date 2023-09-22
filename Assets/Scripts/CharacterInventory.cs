using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterInventoryData", menuName = "CharacterInventoryData", order = 0)]
public class CharacterInventory : ScriptableObject
{
    public List<EquipItemSO> equipItems;
}
