using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour {
	private GameObject obj;
	public GameObject bomb;
	public GameObject strawberry;

	public Random rnd = new Random();
	int num;
	void Start(){
		StartCoroutine(Spawnn());
	}
	void OnGUI() 
	{ 
		GUI.skin.label.fontSize = 36;
		GUI.Label(new Rect(10,10,250,100),"Score: " + Player.score); 
	}	

	IEnumerator Spawnn(){
		while(!Player.lose){
			num = new System.Random().Next(0, 2);
			if(num == 0){
				obj = bomb;
			}else if(num == 1){
				obj = strawberry;
			}
			Instantiate(obj, new Vector2(Random.Range(-1.83f,1.83f), 5.8f), Quaternion.identity);
			yield return new WaitForSeconds(1.5f);
		}
	}
}
