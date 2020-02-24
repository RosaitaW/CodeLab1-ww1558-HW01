using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prizeScript2 : MonoBehaviour
{
    public static int currentLevel = 1;
    public int targetScore2;
    // Start is called before the first frame update
    void Start()
    {
        targetScore2 = PlayerController2.instance.score2 * 2 + 10;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<PlayerController2>().score2++;
        //PlayerController2.instance.score2++;
        Debug.Log("Score2: " + PlayerController2.instance.score2);
        transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));
        if (PlayerController2.instance.score2 > targetScore2)
        {
            currentLevel++;
            SceneManager.LoadScene(currentLevel);
        }
    }
}
