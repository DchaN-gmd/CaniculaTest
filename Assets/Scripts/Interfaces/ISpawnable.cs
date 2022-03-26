using UnityEngine;
using UnityEngine.UI;

public interface ISpawnable 
{
    public void SetPosition(Vector2 position);
    public GameObject GetGameObject();
}