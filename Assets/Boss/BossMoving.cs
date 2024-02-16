using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoving : MonoBehaviour
{
    //speed of the demon moving 
    [SerializeField] float speed = 0.005f;
    [SerializeField] float minY = -4f;
    [SerializeField] float maxY = 4f;
    //made reference prefab of the baby dragon
    [SerializeField] GameObject babyPrefab;
    //the boolean travelDirection is true when we are going up and false when we are going down.
    bool travelDirection = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (travelDirection == true )
        {//we are moving up
            transform.Translate(speed * Vector3.up);
        }
        else
        {//we are moving down
            transform.Translate(speed * Vector3.down);
        }
        //if we hit the top change direction
        if(transform.position.y > maxY)
        {
            travelDirection = false;
        }
        //if we hit the bottom change direction
        if(transform.position.y < minY ) 
        { 
            travelDirection = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //make a new baby everytime space is pushed
            Instantiate(babyPrefab);
        }
    }
}