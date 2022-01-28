using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public string bulletDirection = "up";
    [SerializeField] float bulletSpeed      = 10f;
    [SerializeField] int bulletDamage       = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        switch (bulletDirection)
        {
            case "up":
                Movement(Vector3.right);
                break;
            case "down":
                Movement(Vector3.left);
                break;
            case "right":
                Movement(Vector3.up);
                break;
            case "left":
                Movement(Vector3.down);
                break;
            case "forward":
                Movement(Vector3.forward);
                break;
            case "back":
                Movement(Vector3.back);
                break;
            default:
                break;

        }
    }

    void Inputs()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            bulletDirection = "up";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            bulletDirection = "down";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            bulletDirection = "left";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bulletDirection = "right";
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            bulletDirection = "forward";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            bulletDirection = "back";
        }


    }


    void Movement (Vector3 dir)
    {
        transform.Translate(dir * bulletSpeed * Time.deltaTime);
    }
}
