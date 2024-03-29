using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoving : MonoBehaviour
{
    //speed of the demon moving 
    [SerializeField] float speed = 5f;
    [SerializeField] float minY = -4f;
    [SerializeField] float maxY = 4f;
    //made reference prefab of the baby dragon
    [SerializeField] GameObject babyPrefab;
    [SerializeField] GameObject demonPrefab;
    [SerializeField] int Demon2BabyRatio = 50;
    float futureTime = 0f; //this is the time when we will istantiate a baby or demon
    [SerializeField] float minRange = 1f;
    [SerializeField] float maxRange =3f;

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
            transform.Translate(Time.deltaTime * speed * Vector3.up);
        }
        else
        {//we are moving down
            transform.Translate(Time.deltaTime * speed * Vector3.down);
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

        if (Time.time > futureTime)//
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            futureTime = Time.time + Random.Range(minRange, maxRange);
            int r = Random.Range(0, 100);
            if (r < Demon2BabyRatio)
            {
                Instantiate(demonPrefab, transform.position ,transform.rotation);
            }
            else
            {
                //function to make a new baby everytime space is pushed, returns a reference to the pbject that was created
                Instantiate(babyPrefab, transform.position, transform.rotation);
            }
            //function to make a new baby everytime space is pushed, returns a reference to the pbject that was created
            //Instantiate(babyPrefab, transform.position, transform.rotation);
            /*
             //make a new baby everytime space is pushed, returns a reference to the pbject that was created
            GameObject obj;
            obj= Instantiate(babyPrefab);
            //Vector3.zero is equivalent to new Vector3(0,0,0)
            //spews babys out of the boss
            obj.transform.position = transform.position;*/

        }
    }
}
