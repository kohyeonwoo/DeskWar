using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.RegistUnit(this);
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
        
            Touch touch = Input.GetTouch(0);
        
            if(touch.phase == TouchPhase.Began)
            {
                this.transform.position = Camera.main.ScreenToWorldPoint
                    (new Vector3(touch.position.x, touch.position.y, 5));
            }

        }
    }

}
