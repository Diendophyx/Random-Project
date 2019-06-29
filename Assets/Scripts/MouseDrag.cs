using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    float distance = 10f;

    private void OnMouseDrag()
    {
        Vector2 mousePosi = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosi);
        transform.position = objPosition;
    }
}
