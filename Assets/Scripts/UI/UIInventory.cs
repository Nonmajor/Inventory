using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private List<ItemSlot> itemSlots;
    // �ڷΰ���� �κ��丮 ����

    private void Start()
    // ���� ���� ��, �ڷ� ���� ��ư�� Ŭ�� �̺�Ʈ �����ʸ� �߰�
    {
        backButton.onClick.AddListener(OpenMainMenu);
    }

    public void InitInventoryUI()
    // �÷��̾� �κ��丮 �����͸� ������� ������ ���� UI�� �ʱ�ȭ
    {
        var playerInventory = GameManager.Instance.Player.Inventory;
        // GameManager���� �÷��̾��� �κ��丮 �����͸� ������

        for (int i = 0; i < itemSlots.Count; i++)
        // �Ҵ�� ��� ������ ������ ��ȸ��
        {
            if (i < playerInventory.Count)
            {
                itemSlots[i].SetItem(playerInventory[i]); // ������ ������ ����
            }
            else
            {
                itemSlots[i].SetItem(null); // ���� ����
            }
        }
    }

    public void RefreshAllSlots()
    // ��� ������ ������ UI�� �� ���� ���ΰ�ħ
    {
        foreach (var slot in itemSlots)
        // ������ ���� ����Ʈ�� ��ȸ�ϸ� �� ������ RefreshUI() �޼��带 ȣ��
        {
            slot.RefreshUI();
        }
    }

    private void OpenMainMenu()
    // ���� �κ��丮 UI�� ��Ȱ��ȭ�ϰ� ���� �޴� UI�� Ȱ��ȭ�Ͽ� ȭ���� ��ȯ
    {
        gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }
}