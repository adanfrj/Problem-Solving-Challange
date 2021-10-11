using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int nilaiScore;
    // Start is called before the first frame update
    void Start()
    {
        nilaiScore = 0;
        ScoreText.text = "Score : " + nilaiScore;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "MyCube")
        {
            nilaiScore += 1;
            Destroy(other.gameObject);
            ScoreText.text = "Score : " + nilaiScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
