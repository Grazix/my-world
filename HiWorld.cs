using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiWorld : MonoBehaviour
{
    public int health = 100;
    public float speed = 1.2f;
    public int lvl = 10;
    // Start is called before the first frame update
    void Start()
    {
        health += lvl;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        //print("hi world");
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.y += speed * Time.deltaTime; 
        transform.position = newPosition;

    }
}
