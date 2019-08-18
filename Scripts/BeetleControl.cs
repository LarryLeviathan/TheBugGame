using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeetleControl : MonoBehaviour
{
    public GameObject Child;
   // public Transform Cube;
    public float Speed;
    //public float Distance;
    public int Attack;
    public int Sting;
    public int HP;
    public static bool Die = false;
 


    // public static int Value;
    //public float Limit = 2;
    //public bool Go = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Go == true)
        {
            Distance = Vector3.Distance(transform.position, Cube.position);

            if (Distance < Limit)
            {
                
            }
        }
        /*  if (HP < 10000)
          {
              Destroy(gameObject);

              {
                  // Instantiate the projectile at the position and rotation of this transform
                  GameObject clone;
                  clone = Instantiate(Child, transform.position, transform.rotation);

                  // Give the cloned object an initial velocity along the current
                  // object's Z axis
              } */
        //   }
        transform.Translate(Vector2.up * Time.deltaTime * Speed);

    }
    public void OnBecameInvisible()
    {
        GameControl.lives = GameControl.lives + Attack;

        Destroy(gameObject);
      //s  print("Bonk");
        

        
    
}

    public void OnMouseDown()
    {
        if (GameControl.lives <= 10)
        {
            GameControl.lives = GameControl.lives - Attack;
            GameControl.lives = GameControl.lives - Sting;
            Die = true;



        }



        HP--;

        if (HP < 1)
        {
            Destroy(gameObject);


            {
                GameObject clone;
                clone = Instantiate(Child, transform.position, transform.rotation);

            }

        }
    }

  /*  public void (Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            print("Bonk");

            Destroy(gameObject);
            print("Bonk");
        }

    }
    */
    public Vector3 obj1;
    public Vector3 obj2;
    //public int CubeDistance = Vector3.Distance(obj1.position, obj2.position);
}

  