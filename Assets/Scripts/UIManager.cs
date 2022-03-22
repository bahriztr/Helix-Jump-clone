using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : Singleton<UIManager>
{
    [SerializeField] private Text scoreText;
    public int score;

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
