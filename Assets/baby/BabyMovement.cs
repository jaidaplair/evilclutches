using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BabyMovement : MonoBehaviour
{
    [SerializeField] float speed = 4f;
  //  [SerializeField] AudioClip scream;
    //private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //destroy object after a certain amount of seconds
        Destroy(gameObject, 3.6f);
    }

    // Update is called once per frame
    void Update()
    {
        //move left across the screen
        transform.Translate(Time.deltaTime * speed * Vector3.left);

    }
    private void OnDestroy()
    {
        //find and return the first object you see with a gamemanager component in it
       
        //audioSource.PlayOneShot(scream);
    }
    
}
