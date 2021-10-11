using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    public Rigidbody2D rbball;
    public AudioSource audio;
    public GameManager gm;
    public bool inPlay;
    public Transform paddle;
    public float speed;

    void Start()
    {
        rbball = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

   void OnCollisionEnter2D (Collision2D other)
   {
       if (other.transform.CompareTag("brick"))
       {
           Destroy(other.gameObject);
           audio.Play();
           gm.UpdateScore (other.gameObject.GetComponent<brick>().point);
           gm.UpdateNumberOfBrick();
       }
   }

   void OnTriggerEnter2D (Collider2D other)
   {
       if (other.CompareTag ("bottom"))
       {
           rbball.velocity = Vector2.zero;
           inPlay = false;
           gm.UpdateLives(-1);
       }
   }

   void Update()
   {
       if (gm.gameOver)
       {
           return;
       }
    
        if (gm.nextLevel)
        {
            return;
        }

       if (!inPlay)
       {
           transform.position = paddle.position;
       }

       if (Input.GetKeyDown(KeyCode.Space) && !inPlay)
       {
           inPlay = true;
           rbball.AddForce(Vector2.up * speed);
       }
   }
}
