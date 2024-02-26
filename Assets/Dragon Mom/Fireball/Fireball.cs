using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    
    //[SerializeField] AudioClip firingSound;
   // private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
        //destroy object after a certain amount of seconds
        Destroy(gameObject, 3.6f);
    }

    // Update is called once per frame
    void Update()
    {
        //move left across the screen
        transform.Translate(Time.deltaTime * speed * Vector3.right);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   //find and return the first object you see with a gamemanager component in it
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();

        if (collision.CompareTag("demon") == true)
        {   //increment score
            gm.score += 10;
            //play demon sound 
        }
        if (collision.CompareTag("baby") == true)
        {   //decrement score
            gm.score -= 15;
            //play baby sound 
        }



        Destroy(collision.gameObject);//destroy object we hit
        Destroy(gameObject);//destroy the fireball
        //Debug.Log("Ive been triggered!!!!!!!!!"+ collision.name);
    }
}
