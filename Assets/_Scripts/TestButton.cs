﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestButton : MonoBehaviour
{

    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        LivesLabel.rectTransform.anchoredPosition = new Vector2(417.0f, -136.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-351.0f, -136.0f);
    }
}
