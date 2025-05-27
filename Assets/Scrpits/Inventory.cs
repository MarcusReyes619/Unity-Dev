using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Aggregate<Item>
{
    [SerializeField] List<Item> items;
    public Item currentItem { get; private set; }

    public Inventory(List<Item> items)
    {
        this.items = items;
    }
    private void Start()
    {
        currentItem = items[0];
        currentItem.Equip();
    }

    public void Use()
    {
        currentItem?.Use();
    }

    public void StopUse()
    {
        currentItem?.StopUse();
    }

    public Iterator<Item> createIterator()
    {
        return new ItemInerator(items);
    }
}
