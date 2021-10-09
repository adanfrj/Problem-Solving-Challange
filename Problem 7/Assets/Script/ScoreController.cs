using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text myScoreText;
    private int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        myScoreText.text = "Score : " + scoreValue;
    }

    private void OnTriggerEnter2D(Collider2D Cube)
    {
        if (Cube.tag == "MyCube")
        {
            scoreValue += 1;
            Destroy(Cube.gameObject);
            myScoreText.text = "Score : " + scoreValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
