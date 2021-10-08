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

    [SerializeField]
    private float _speed;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}