using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame() {
        Application.Quit();
    }
    public void BackToMenu() {
        SceneManager.LoadScene("StartTheGame", LoadSceneMode.Single);
    }
}
