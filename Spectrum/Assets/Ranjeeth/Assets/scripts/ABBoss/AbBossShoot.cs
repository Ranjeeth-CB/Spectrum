﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbBossShoot : MonoBehaviour
{
     GameObject player;
    public GameObject[] projectile;
    private int bossColor;
    public float firerate = 0.2f;
    private float timer;
    private Rigidbody2D rigidbody;
    public float bulletforce = 20f;
    Vector2 dirn;
    float magnitude;
    public Transform target2;







    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        



         
        

        
    }

    // Update is called once per frame
    void Update()
    {
        bossColor = ABBossBehaviour.currentColor;
        //if(this.transform.position != target.position )
        //{
            dirn = (Vector2)player.transform.position - (Vector2)this.transform.position;
        magnitude = dirn.magnitude;




        timer += Time.deltaTime;
        if(timer >= firerate)
        {
            timer -= firerate;
            GameObject A = Instantiate(projectile[bossColor], (Vector2)this.transform.position + (dirn/magnitude) * 7 , Quaternion.identity );
            rigidbody = A.GetComponent<Rigidbody2D>();
            rigidbody.velocity  = (bulletforce*(dirn/magnitude));




        }

        //}
       
        

        
    }

}
