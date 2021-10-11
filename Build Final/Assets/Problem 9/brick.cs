using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public int point;
    public int jmlbrick;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

}
