
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public Transform player;
	private Vector3 mousePosition;
	[SerializeField]
	private float speed = 6.0f;

	void Start(){
	
	}
	void OnMouseDrag(){
		if(!Player.lose){
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.x = mousePosition.x > 1.83f ? 1.83f : mousePosition.x;
		mousePosition.x = mousePosition.x <-1.83f ? -1.83f : mousePosition.x;
		player.position = Vector2.MoveTowards(player.position,new Vector2(mousePosition.x, player.position.y), speed * Time.deltaTime);
		}
	}
}
