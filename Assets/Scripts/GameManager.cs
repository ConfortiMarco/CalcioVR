using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour, IGameManager
{
    [SerializeField]
    private GameObject gameObject;
    [SerializeField]
    private GameObject goalkeeper;
    [SerializeField]
    private GameObject slider;

    public void SetVisibleCanvas()
    {
        gameObject.SetActive(!gameObject.active);
    }

    public void ChangeScale()
    {
        goalkeeper.GetComponent<MoveGoalkeeper>().Velocity = slider.GetComponent<Slider>().value;
    }

    public void MenuBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
