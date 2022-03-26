using UnityEngine;

public class Item : MonoBehaviour, ISpawnable
{
    [SerializeField] private Transform _rectTransform;

    public void SetPosition(Vector2 position)
    {
        _rectTransform.GetComponent<RectTransform>().anchoredPosition = position;
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }
}
