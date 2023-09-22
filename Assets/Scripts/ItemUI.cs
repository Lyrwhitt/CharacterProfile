using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour
{
    private EquipItemSO _itemData;

    [SerializeField]
    private GameObject _isEquipImg;

    public void SetItemData(EquipItemSO data)
    {
        _itemData = data;
    }

    public EquipItemSO GetItemData()
    {
        return _itemData;
    }

    public void EquipOn()
    {
        _isEquipImg.SetActive(true);
        _itemData.isEquip = true;
    }
    public void EquipOff()
    {
        _isEquipImg.SetActive(false);
        _itemData.isEquip = false;
    }
}
