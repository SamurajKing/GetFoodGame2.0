using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Starting : MonoBehaviour {

	void Awake(){
		Screen.orientation = ScreenOrientation.Portrait;
	}
	void OnMouseDown()
	{
		SceneManager.LoadScene("game");
	}
}
