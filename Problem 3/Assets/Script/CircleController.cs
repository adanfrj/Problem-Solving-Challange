using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProblemStep
{
    problem2, problem3, problem4, problem5, problem6, problem7, problem8, problem9, problem10,
}

public class CircleController : MonoBehaviour
{
    [SerializeField]
    private ProblemStep _problemStep;

    [SerializeField]
    private Rigidbody2D _rb2d;

    //variabel problem 2
    [SerializeField]
    private float _speed;

    //variabel problem 3
    public float xInitialForce;
    public float yInitialForce;

    // Start is called before the first frame update
    public void Problem2()
    {
        if (_problemStep == ProblemStep.problem2)
        {
            _speed = 5;
            _rb2d.velocity = new Vector2(_speed, _rb2d.velocity.y);
            _rb2d.velocity = new Vector2(_speed, _rb2d.velocity.x);
        }
    }

    public void Problem3()
    {
        //problem step 3
        if (_problemStep == ProblemStep.problem3)
        {
            // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
            float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

            // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
            float randomDirection = Random.Range(0, 2);

            // Jika nilainya di bawah 1, bola bergerak ke kiri. 
            // Jika tidak, bola bergerak ke kanan.
            if (randomDirection < 1.0f)
            {
                // Gunakan gaya untuk menggerakkan bola ini.
                _rb2d.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
            }
            else
            {
                _rb2d.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}