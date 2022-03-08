using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{   
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
       Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
    }
}
