using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private List<ItemSlot> itemSlots;
    // 뒤로가기와 인벤토리 슬롯

    private void Start()
    // 게임 시작 시, 뒤로 가기 버튼에 클릭 이벤트 리스너를 추가
    {
        backButton.onClick.AddListener(OpenMainMenu);
    }

    public void InitInventoryUI()
    // 플레이어 인벤토리 데이터를 기반으로 아이템 슬롯 UI를 초기화
    {
        var playerInventory = GameManager.Instance.Player.Inventory;
        // GameManager에서 플레이어의 인벤토리 데이터를 가져옴

        for (int i = 0; i < itemSlots.Count; i++)
        // 할당된 모든 아이템 슬롯을 순회함
        {
            if (i < playerInventory.Count)
            {
                itemSlots[i].SetItem(playerInventory[i]); // 아이템 데이터 설정
            }
            else
            {
                itemSlots[i].SetItem(null); // 슬롯 비우기
            }
        }
    }

    public void RefreshAllSlots()
    // 모든 아이템 슬롯의 UI를 한 번에 새로고침
    {
        foreach (var slot in itemSlots)
        // 아이템 슬롯 리스트를 순회하며 각 슬롯의 RefreshUI() 메서드를 호출
        {
            slot.RefreshUI();
        }
    }

    private void OpenMainMenu()
    // 현재 인벤토리 UI를 비활성화하고 메인 메뉴 UI를 활성화하여 화면을 전환
    {
        gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }
}