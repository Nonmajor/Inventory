using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string ID { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }
    public int AttackPower { get; private set; }
    public int DefensePower { get; private set; }


    // ID, 레벨, 골드, 총 공격력, 총 방어력



    public List<ItemData> Inventory { get; private set; }
    public List<ItemData> EquippedItems { get; private set; }

    // 인벤토리, 장착한 아이템


    public Character(string id, int level, int gold)
    // 캐릭터 클래스 생성자

    {
        ID = id;
        Level = level;
        Gold = gold;
        AttackPower = 10;
        DefensePower = 5;
        Inventory = new List<ItemData>();
        EquippedItems = new List<ItemData>();
    }

    public void AddItem(ItemData item)
    // 아이템 추가 메서드

    {
        Inventory.Add(item);
    }

    public void Equip(ItemData item)
    // 아이템 장착 메서드

    {
        EquippedItems.Add(item);
        AttackPower += item.attackBonus;
        DefensePower += item.defenseBonus;
    }

    public void UnEquip(ItemData item)
    // 아이템 장착 해제 메서드

    {
        // 특정 아이템을 리스트에서 제거
        if (EquippedItems.Contains(item))
        {
            EquippedItems.Remove(item);
            AttackPower -= item.attackBonus;
            DefensePower -= item.defenseBonus;
        }
    }


    public bool IsEquipped(ItemData item)
    // 특정 아이템의 장착 상태 확인
    {
        return EquippedItems.Contains(item);
    }
}