using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MomMoving : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float minY = -4f;
    [SerializeField] float maxY = 4f;
    [SerializeField] float y = 0.0005f;
    [SerializeField] GameObject fireballPrefab;
    bool travelDirection = true;
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Input.GetAxis("Horizontal");
       // Debug.Log(x);
        float y = Input.GetAxis("Vertical");
        
        transform.Translate(Time.deltaTime * y * speed * Vector3.up);
        
        //peg the movement to max y
        if (transform.position.y > maxY)
        {
           transform.position = new Vector3(transform.position.x, maxY, 0f);    
        }
        //peg the movement to min y
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float newY = transform.position.y + 0.59f;
            float newX = transform.position.x + 0.5f;

            //Fire();

            Instantiate(fireballPrefab, new Vector3(newX,newY,transform.position.z), transform.rotation);
            //Fire();
        }
        /*void Fire()
        {
            // Play firing sound
            if (firingSound != null)
            {
                audioSource.PlayOneShot(firingSound);

            }
        }*/
        //Debug.Log(y);
        /*  if (travelDirection == true)
          {//we are moving up
              transform.Translate(speed * Vector3.up);
          }
          else
          {//we are moving down
              transform.Translate(speed * Vector3.down);
          }
          //if we hit the top change direction
          if (transform.position.y > maxY)
          {
              travelDirection = false;
          }
          //if we hit the bottom change direction
          if (transform.position.y < minY)
          {
              travelDirection = true;
          }*/
    }
}
