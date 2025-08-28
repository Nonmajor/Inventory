using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private GameObject equipMark;
    // ������Ʈ �Ҵ�

    private ItemData currentItem;
    // ������ ������ ���� ����

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnItemSlotClicked);
        // ��ư Ŭ���� OnItemSlotClicked�� ����
    }

    public void SetItem(ItemData item)
    // ���Կ� ������ ������ ����
    {
        currentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    // ���� ������ �����Ϳ� ���� UI ������Ʈ
    {
        if (currentItem != null)
        {
            itemIcon.sprite = currentItem.icon;
            itemIcon.gameObject.SetActive(true);
            // ������ �̹����� ������Ʈ�� Ȱ��ȭ�ϰ�, �������� ������ ��������Ʈ�� �Ҵ�

            equipMark.SetActive(GameManager.Instance.Player.IsEquipped(currentItem));
            // Character�� IsEquipped �޼��带 ���� ���� ���� Ȯ��
        }
        else
        {
            itemIcon.gameObject.SetActive(false);
            equipMark.SetActive(false);
            // �����ܰ� equipMark ������Ʈ�� ��� ��Ȱ��ȭ
        }
    }

    private void OnItemSlotClicked()
    // ������ ����/���� ó��
    {
        if (currentItem == null) return;

        // �������� �̹� ������ ���¶�� ����
        if (GameManager.Instance.Player.IsEquipped(currentItem))
        {
            GameManager.Instance.Player.UnEquip(currentItem); // Ư�� ������ ����
        }

        // �������� ���� ���¶�� ����
        else
        {
            GameManager.Instance.Player.Equip(currentItem); // Ư�� ������ ����
        }

        // ĳ������ ����� ������ ����â�� �ݿ��ϰ� ��� ������ UI�� ���ΰ�ħ
        UIManager.Instance.UIStatus.SetCharacterData(GameManager.Instance.Player);
        UIManager.Instance.UIInventory.RefreshAllSlots();
    }
}




