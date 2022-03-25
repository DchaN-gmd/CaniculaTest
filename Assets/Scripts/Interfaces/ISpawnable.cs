using UnityEngine;
using UnityEngine.UI;

public interface ISpawnable 
{
    public void SetPosition(Vector2 position);
    public GameObject GetGameObject();
}

//public abstract class Item : MonoBehaviour
//{
//    public virtual void SetPosition(RectTransform position)
//    {

//    }
//}