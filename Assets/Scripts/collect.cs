using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class collect : MonoBehaviour
{
    private int totalTiles;
    private int counter;
    [SerializeField] TextMeshProUGUI scoreText;
    private int score;
    


    void Start()
    {

        totalTiles = transform.childCount;
    }


    // Update is called once per frame
    void Update()
    {

        
        counter = transform.childCount;
        score = ((totalTiles - counter) * 10);
        scoreText.text = "Score: " + score.ToString();
    }
}
