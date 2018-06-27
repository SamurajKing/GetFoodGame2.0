using UnityEngine;

public class Player : MonoBehaviour {
	public static bool lose = false;
	public static int score;
	public GameObject restart;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "bomb"){
			lose = true;
			Destroy(other.gameObject);
			restart.SetActive(true);
		}else if(other.gameObject.tag == "strawberry"){
			Destroy(other.gameObject);
			score += 100;
		}
	}
}
