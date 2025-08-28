using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string ID { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }
    public int AttackPower { get; private set; }
    public int DefensePower { get; private set; }


    // ID, ����, ���, �� ���ݷ�, �� ����



    public List<ItemData> Inventory { get; private set; }
    public List<ItemData> EquippedItems { get; private set; }

    // �κ��丮, ������ ������


    public Character(string id, int level, int gold)
    // ĳ���� Ŭ���� ������

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
    // ������ �߰� �޼���

    {
        Inventory.Add(item);
    }

    public void Equip(ItemData item)
    // ������ ���� �޼���

    {
        EquippedItems.Add(item);
        AttackPower += item.attackBonus;
        DefensePower += item.defenseBonus;
    }

    public void UnEquip(ItemData item)
    // ������ ���� ���� �޼���

    {
        // Ư�� �������� ����Ʈ���� ����
        if (EquippedItems.Contains(item))
        {
            EquippedItems.Remove(item);
            AttackPower -= item.attackBonus;
            DefensePower -= item.defenseBonus;
        }
    }


    public bool IsEquipped(ItemData item)
    // Ư�� �������� ���� ���� Ȯ��
    {
        return EquippedItems.Contains(item);
    }
}