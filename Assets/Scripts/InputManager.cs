using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Camera _camera;

    private void Awake()
    {
        _camera = FindObjectOfType<Camera>();
    }

    public void GetTouchPosition(TargetZone targetZone)
    {
#if UNITY_ANDROID
        {
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                Vector2 localPostion;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(targetZone.GetComponent<RectTransform>(), touch.position, _camera, out localPostion);
                targetZone.SpawnItem(localPostion);
            }
        }
#endif

//#if UNITY_EDITOR_WIN
//        {
//            Vector2 localPostion;
//            RectTransformUtility.ScreenPointToLocalPointInRectangle(targetZone.GetComponent<RectTransform>(), Input.mousePosition, _camera, out localPostion);
//            targetZone.SpawnItem(localPostion);
//        }
//#endif
    }
}
