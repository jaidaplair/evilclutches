using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //all 3 do the same thing
        //transform.Translate(0.005f, 0f, 0f);

        //Vector3 someVector = new Vector3(0.005f, 0f, 0f);
        //transform.Translate(someVector);

        transform.Translate(Time.deltaTime * speed * Vector3.right);//best version because of coordinate system
    }
}
