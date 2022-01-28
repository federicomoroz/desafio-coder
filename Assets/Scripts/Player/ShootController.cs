using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{

    [SerializeField] float shootRate = 0.5f;
    [SerializeField] GameObject bulletPrefab;
    

    void Start()
    {
        
        
    }

    void Update()
    {
        Inputs();
        
    }

    void Inputs()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ShootManager(2);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            ShootManager(3);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            ShootManager(4);
        }
    }

    void ShootManager (int q)
    {
        StartCoroutine(Shoot(q, shootRate));
               
    } 

    IEnumerator Shoot(int ammo, float rate)
    {
        

        if (ammo > 0)
        {              
        Instantiate(bulletPrefab, transform);
        ammo--;
        yield return new WaitForSeconds(rate);
            if (ammo > 0) 
            { 
            StartCoroutine (Shoot(ammo, rate));
            }
        }
        else
        {            
            StopAllCoroutines();           
        }

    }



}
