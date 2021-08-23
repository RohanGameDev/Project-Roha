using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

 
    private float timeBtwShots;
    public float startTimeBtwShots;
    public Transform firePoint;
    public GameObject bulletprefab;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        

         if (timeBtwShots <= 0)
         {
             Instantiate(bulletprefab, firePoint.position, Quaternion.identity);
             timeBtwShots = startTimeBtwShots;
         }
         else
         {
             timeBtwShots -= Time.deltaTime;
         }

    }
}
