using UnityEngine;

public class Star : MonoBehaviour, ISpawnable
{
    [SerializeField] private Transform _rectTransform;

    private void Start()
    {
        _rectTransform = gameObject.GetComponent<RectTransform>();
    }

    public void SetPosition(Vector2 position)
    {
        _rectTransform.localPosition = position;
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }
}
