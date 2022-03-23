using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbBossMove : MonoBehaviour
{
    GameObject player;
    public float speed = 1f;
    Vector2 target;
    public Transform targetPos1;
    public Transform targetPos2;




    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");

        target = new Vector2(targetPos1.transform.position.x , targetPos1.transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y == targetPos2.position.y)
        {
            target = new Vector2(targetPos1.transform.position.x , targetPos1.transform.position.y);

        }
        else if(this.transform.position.y == targetPos1.position.y )
        {
            target = new Vector2(targetPos2.transform.position.x , targetPos2.transform.position.y);

            

        }
        
        transform.position = Vector2.MoveTowards(transform.position , target , speed);

    
        
    }
}
