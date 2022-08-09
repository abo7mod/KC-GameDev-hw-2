using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public Rigidbody Rg;
    public bool left;




    // Start is called before the first frame update
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Rg.velocity = new Vector2(0f,speed);
            }
        }



        else if (left)
        {
            if (Input.GetKey(KeyCode.D))
            {
                Rg.velocity = new Vector2(0f, -speed);
            }
            else
            {
                Rg.velocity = new Vector2(0f,0f);

            }
        }
        else
        {

            if (left)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Rg.velocity = new Vector2(0f, speed);
                }
            }



            else if (left)
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Rg.velocity = new Vector2(0f, -speed);
                }
            }
            else
            {
                Rg.velocity = new Vector2(0f, 0f);

            }


        }

    }
}
