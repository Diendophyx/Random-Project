using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool touchDown;
    private bool mouseSelected;
    public Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
       #region Touch
       if (Input.touchCount > 0)
       {
           Touch touch = Input.GetTouch(0);
           Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
       
           if (touch.phase == TouchPhase.Began)
           {
               Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
               if (col == touchedCollider)
               {
                   touchDown = true;
               }
           }
       
           if (touch.phase == TouchPhase.Moved)
           {
               if (touchDown == true)
               {
                   transform.position = new Vector2(touchPosition.x, touchPosition.y); 
               }
           }
       
           if (touch.phase == TouchPhase.Ended)
           {
               touchDown = false;
           }
       }
       #endregion
        #region Mouse
        //if (mouseSelected == true)
        //{
        //    Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    transform.position = new Vector2(cursorPosition.x, cursorPosition.y);
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    mouseSelected = false;
        //}
       #endregion
    }
}
