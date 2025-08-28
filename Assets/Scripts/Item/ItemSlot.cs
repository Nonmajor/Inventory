using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private GameObject equipMark;
    // 컴포넌트 할당

    private ItemData currentItem;
    // 아이템 데이터 저장 변수

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnItemSlotClicked);
        // 버튼 클릭을 OnItemSlotClicked에 연결
    }

    public void SetItem(ItemData item)
    // 슬롯에 아이템 데이터 설정
    {
        currentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    // 현재 아이템 데이터에 맞춰 UI 업데이트
    {
        if (currentItem != null)
        {
            itemIcon.sprite = currentItem.icon;
            itemIcon.gameObject.SetActive(true);
            // 아이콘 이미지와 오브젝트를 활성화하고, 아이템의 아이콘 스프라이트를 할당

            equipMark.SetActive(GameManager.Instance.Player.IsEquipped(currentItem));
            // Character의 IsEquipped 메서드를 통해 장착 여부 확인
        }
        else
        {
            itemIcon.gameObject.SetActive(false);
            equipMark.SetActive(false);
            // 아이콘과 equipMark 오브젝트를 모두 비활성화
        }
    }

    private void OnItemSlotClicked()
    // 아이템 장착/해제 처리
    {
        if (currentItem == null) return;

        // 아이템이 이미 장착된 상태라면 해제
        if (GameManager.Instance.Player.IsEquipped(currentItem))
        {
            GameManager.Instance.Player.UnEquip(currentItem); // 특정 아이템 해제
        }

        // 장착되지 않은 상태라면 장착
        else
        {
            GameManager.Instance.Player.Equip(currentItem); // 특정 아이템 장착
        }

        // 캐릭터의 변경된 스탯을 상태창에 반영하고 모든 슬롯의 UI를 새로고침
        UIManager.Instance.UIStatus.SetCharacterData(GameManager.Instance.Player);
        UIManager.Instance.UIInventory.RefreshAllSlots();
    }
}




