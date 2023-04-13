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
        //ball'ýn y'si kameranýn y'sinin pozisyonundan büyükse yeni pozisyonu ball'ýn y'sine eþitleyelim.
        if(ball.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,ball.position.y,transform.position.z);
        }
        
    }
}
