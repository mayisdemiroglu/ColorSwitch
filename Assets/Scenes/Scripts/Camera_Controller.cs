using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Transform ball;
    void Start()
    {
        
    }

    
    void Update()
    {
        //ball'�n y'si kameran�n y'sinin pozisyonundan b�y�kse yeni pozisyonu ball'�n y'sine e�itleyelim.
        if(ball.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,ball.position.y,transform.position.z);
        }
        
    }
}
