using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = FindObjectOfType<Camera>();
    }

    public void GetTouchPosition(TargetZone targetZone)
    {
        Touch touch;
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            targetZone.SpawnItem(touch.position);
            //RectTransformUtility.WorldToScreenPoint(_camera, touch.position)
        }

    }
}
