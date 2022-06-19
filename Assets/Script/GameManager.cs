using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public Text ScoreText;
    public GameObject ScorePanel;
    // Start is called before the first frame update
    void Start()
    {
        ScorePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            canvas.SetActive(false);
            ScorePanel.SetActive(true);
        }
    }
}
