using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour {

	void OnMouseDown()
	{
		SceneManager.LoadScene("game");
		Player.lose = false;
	}
}
