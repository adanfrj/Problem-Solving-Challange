using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 5f;
    public GameManager gm;
    public AudioSource audio;
    

    // Tombol untuk menggerakkan ke kanan
    public KeyCode rightButton = KeyCode.D;
 
    // Tombol untuk menggerakkan ke bawah
    public KeyCode leftButton = KeyCode.A;

    private Rigidbody2D rigidBody2D;

    void OnCollisionEnter2D (Collision2D other)
   {
       if (other.transform.CompareTag("ball"))
       {
           audio.Play();
       }
   }

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Dapatkan kecepatan raket sekarang.
        Vector2 velocity = rigidBody2D.velocity;
 
        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
 
        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }
 
        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.x = 0.0f;
        }
 
        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        if (gm.gameOver)
        {
            return;
        }
    }
}
