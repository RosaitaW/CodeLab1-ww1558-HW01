﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prizeScript : MonoBehaviour
{
    public static int currentLevel = 1;
    public int targetScore1;
    // Start is called before the first frame update
    void Start()
    {
        targetScore1 = PlayerControler.instance.score * 2 + 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<PlayerControler>().score++;
        //PlayerControler.instance.score++;
        Debug.Log("Score: " + PlayerControler.instance.score);
        transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));
        if (PlayerControler.instance.score > targetScore1) {
            currentLevel++;
            SceneManager.LoadScene(currentLevel);
        }
    }
}
