using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
   
    void Update()
    {
       if (Input.touchCount > 0)
       {
           Touch t = Input.GetTouch(0);

           Vector3 pos = Camera.main.ScreenToWorldPoint(t.position);
           pos.z = 0;
           transform.position = pos;
       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "box")
        {
            Destroy(this.gameObject);
        }
    }
}
