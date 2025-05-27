using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iterator<T>
{
    bool hasNext();
    T next();
}

public interface Aggregate<T>
{
    Iterator<T> createIterator();
}

public class ItemInerator : Iterator<Item>
{
    private int currentIndex = 0;
    private List<Item> items;

    public ItemInerator(List<Item> items)
    {
        this.items = items;
    }
    public bool hasNext()
    {
        return currentIndex < items.Count;
    }

    public Item next()
    {
        if (!hasNext())
        {
            return null;
        }
        return items[currentIndex];
    }
}



