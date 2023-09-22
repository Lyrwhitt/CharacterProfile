using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : UIPopup
{
    public CharacterInventory inventoryData;
    public CharacterStats characterData;

    public Transform inventoryContentTrans;
    public Button inventoryBackBtn;

    public GameObject inventoryBtnPrefab;

    private List<GameObject> _inventoryBtns = new List<GameObject>();
    private ItemUI _selectedItem;

    [Header("Equip")]
    public Button equipCancelBtn;
    public Button equipConfirmBtn;
    public Text equipStateText;
    public GameObject equipPanel;

    private void Start()
    {
        inventoryBackBtn.onClick.AddListener(InventoryBackBtnClicked);

        equipCancelBtn.onClick.AddListener(EquipCancelBtnClicked);
        equipConfirmBtn.onClick.AddListener(EquipConfirmBtnClicked);
    }

    private void OnEnable()
    {
        UpdateInventory();
    }

    public void InventoryBackBtnClicked()
    {
        UIManager.instance.ClosePopup();
    }

    public void UpdateInventory()
    {
        for (int i = 0; i < inventoryData.equipItems.Count; i++)
        {
            GameObject newBtn = Instantiate(inventoryBtnPrefab, inventoryContentTrans.GetChild(i));
            EquipItemSO itemData = inventoryData.equipItems[i];

            ItemUI newItemUI = newBtn.GetComponent<ItemUI>();
            newItemUI.SetItemData(itemData);

            if (itemData.isEquip)
                newItemUI.EquipOn();
            else
                newItemUI.EquipOff();

            newBtn.GetComponent<Image>().sprite = itemData.img;
            newBtn.GetComponent<Button>().onClick.AddListener(() => InventoryBtnOnClick(newItemUI));

            _inventoryBtns.Add(newBtn);
        }
    }

    public void InventoryBtnOnClick(ItemUI item)
    {
        _selectedItem = item;


        equipPanel.SetActive(true);

        if (item.GetItemData().isEquip)
           equipStateText.text = "장착 해제 하시겠습니까?";
        else
            equipStateText.text = "장착 하시겠습니까?";
        
    }

    public void EquipCancelBtnClicked()
    {
        equipPanel.SetActive(false);
        _selectedItem = null;
    }

    public void EquipConfirmBtnClicked()
    {
        equipPanel.SetActive(false);

        EquipItemSO itemData = _selectedItem.GetItemData();

        if (!itemData.isEquip)
        {
            characterData.equipedItems.Add(itemData);
            _selectedItem.EquipOn();
        }
        else
        {
            characterData.equipedItems.Remove(itemData);
            _selectedItem.EquipOff();
        }
    }
}
