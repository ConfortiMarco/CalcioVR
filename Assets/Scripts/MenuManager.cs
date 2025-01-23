using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject textBestScore;
    void Start()
    {
        int bestScore = PlayerPrefs.GetInt("scoreValue");
        textBestScore.GetComponent<TextMeshProUGUI>().text = "Best Score: " + bestScore.ToString();

    }
    public void StartGame()
    {
        SceneManager.LoadScene("BasicScene");
    }
}
