using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private Text scoreText;
    public int score;
    public GameObject lostPanel;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void Dead()
    {
        lostPanel.gameObject.SetActive(true);
        
    }

    public void PlayNewScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
