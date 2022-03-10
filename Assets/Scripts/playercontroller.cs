using System;
using UnityEngine;

public class playercontroller : MonoBehaviour
{   
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
       surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
     void Update() 
    {
        RotatePlayer();
        RespondToBoost();

    }

    void RotatePlayer()
    {
       {
        if(Input.GetKey(KeyCode.LeftArrow))
        {   
            rb2d.AddTorque(torqueAmount);
        
        }
    
        else if(Input.GetKey(KeyCode.RightArrow))
            {   
                rb2d.AddTorque(-torqueAmount);
            }
      
          }      
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;

        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

}