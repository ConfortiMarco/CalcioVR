using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private GameObject txtScore;
    private int _score;
    private int bestScore;

    public int Score
    {
        get { return _score; }
        set { 
            _score = value;
            if(_score > bestScore)
            {
                bestScore = _score;
                PlayerPrefs.SetInt("scoreValue",bestScore);   
            }
        }
    }

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("scoreValue");
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.GetComponent<TextMeshProUGUI>().text = "Score: " + _score.ToString();
    }
}
