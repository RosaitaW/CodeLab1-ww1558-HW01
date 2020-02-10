using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prizeScript : MonoBehaviour
{
    public GameObject player01;
    public GameObject player02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));

    }
}
