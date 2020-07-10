using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameController>();  // reference of an object
        Screen.orientation = ScreenOrientation.Portrait; // force portrait screen
    }

    // Update is called once per frame
    void Update()
    {
    }
    // checks if game object collides with something
    void OnTriggerEnter2D(Collider2D colisor)
    { 
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
