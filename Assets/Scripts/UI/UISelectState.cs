using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISelectState : UIPopup
{
    public Transform canvasTrans;

    public Button statusBtn;
    public Button inventoryBtn;

    private void Start()
    {
        statusBtn.onClick.AddListener(StatusBtnClicked);
        inventoryBtn.onClick.AddListener(InventoryBtnClicked);
    }

    public void StatusBtnClicked()
    {
        UICharacterStats statusPopup = UIManager.instance.ShowPopup<UICharacterStats>();
        statusPopup.transform.SetParent(canvasTrans, false);
    }

    public void InventoryBtnClicked()
    {
        UIInventory inventoryPopup = UIManager.instance.ShowPopup<UIInventory>();
        inventoryPopup.transform.SetParent(canvasTrans, false);
    }
}
