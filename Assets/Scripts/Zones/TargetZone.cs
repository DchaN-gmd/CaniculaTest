using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public abstract class TargetZone : MonoBehaviour
{
    [SerializeField] protected List<GameObject> _items;
    public virtual void SpawnItem(Vector2 position)
    {
        if(_items.Count == 0)
        {
            throw new System.Exception("Not enough objects");
        }
        var item = GetItem();
        var spawnedItem = Instantiate(item.GetGameObject(), transform);
        spawnedItem.GetComponent<ISpawnable>().SetPosition(position);
        Debug.Log(position);
    }

    protected virtual ISpawnable GetItem()
    {
        var item = _items[Random.Range(0, _items.Count - 1)];
        _items.Remove(item);
        return item.GetComponent<ISpawnable>();
    }
}
