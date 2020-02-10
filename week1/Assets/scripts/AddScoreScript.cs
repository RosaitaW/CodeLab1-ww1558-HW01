using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScoreScript : MonoBehaviour
{
    public GameObject player;
    public Transform prize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreText.scoreValue >= 25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision.gameObject.name == "Diamond") {
            ScoreText.scoreValue += 5;
            prize.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));
        }
    }

    
}
