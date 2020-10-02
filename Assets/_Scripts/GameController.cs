﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //  SceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(280.0f, -204.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-351.0f, -204.0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                //  SceneLabel.text = "LandscapeLeft";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(400.0f, -136.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-351.0f, -136.0f);
                break;
            case DeviceOrientation.LandscapeRight:
                //   SceneLabel.text = "LandscapeRight";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(270.0f, -136.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-480.0f, -136.0f);
                break;
            case DeviceOrientation.Unknown:
             //   SceneLabel.text = "Unknown";
                break;
            default:
             //   SceneLabel.text = "Default";
                break;

        }
        
    }
}
