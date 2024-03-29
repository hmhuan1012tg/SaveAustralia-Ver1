﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPanel : MonoBehaviour
{
    [SerializeField]
    Vector2 offset;

    [SerializeField]
    RectTransform rectTransform;

    public void AlignTo(Vector3 position)
    {
        Vector2 screenPosition = RectTransformUtility.WorldToScreenPoint(Camera.main, position);
        rectTransform.anchoredPosition = screenPosition + offset;
    }
}
