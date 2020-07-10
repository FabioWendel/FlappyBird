using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
	// method to redirect the proper seine
	public void BirdEasy()
	{
		print("funfou..");
		SceneManager.LoadScene("birdEasy");
	}
	// method to redirect the proper seine
	public void BirdHard()
	{
		print("funfou..");
		SceneManager.LoadScene("birdHard");
	}
	// Start is called before the first frame update
	void Start()
    {
		Screen.orientation = ScreenOrientation.Portrait; // force portrait screen
	}
}
