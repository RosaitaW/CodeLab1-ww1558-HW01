using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepPlayer : MonoBehaviour
{
    //static variable means the value is the same for all the objects of this class type and the class itself
    public static keepPlayer instance; //this static var will hold the Singleton

    public Text P1Text;


    private float timer = 0; //keep track of time

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
        P1Text = GetComponentInChildren<Text>(); //get the text component from the children of this gameObject


        // Update is called once per frame
       
    }
    void Update()
    {
        P1Text.text = "Player1 Score: " + PlayerControler.instance.score; //update the text component with the score and time

    }
}
