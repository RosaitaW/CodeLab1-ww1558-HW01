using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepPlayer2 : MonoBehaviour
{
    //static variable means the value is the same for all the objects of this class type and the class itself
    public static keepPlayer2 instance; //this static var will hold the Singleton

    public Text P2Text;//Text Component to tell you the score

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        { //if the instance is already set to an object
            Destroy(gameObject); //destroy this new object, so there is only ever one
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        P2Text = GetComponentInChildren<Text>(); //get the text component from the children of this gameObject
    }

    // Update is called once per frame
    void Update()
    {
        
        P2Text.text = "Player2 Score: " + PlayerController2.instance.score2; //update the text component with the score and time
    }
}
