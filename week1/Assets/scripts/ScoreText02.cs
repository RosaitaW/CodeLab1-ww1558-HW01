using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreText02 : MonoBehaviour
{
    public static int score2Value = 0;
    public string PlayerNumber;
    Text Score2;

    // Start is called before the first frame update
    void Start()
    {
        Score2 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score2.text = PlayerNumber + score2Value;
    }
}