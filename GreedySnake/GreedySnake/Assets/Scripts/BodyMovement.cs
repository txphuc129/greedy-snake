using UnityEngine;
using System.Collections;

public class BodyMovement : MonoBehaviour {

	float speed;
	GameObject  player;
	PlayerMovement playerMovement;
	void Start(){
		player=GameObject.FindGameObjectWithTag("Player");
		playerMovement=player.GetComponent<PlayerMovement>();
		speed=playerMovement.speed;
	}
	
	void FixedUpdate(){
		if(playerMovement.isDead) return;
		Moving();
	}
	void Moving(){
		speed=playerMovement.speed;
		transform.position+=transform.forward*speed*Time.deltaTime;
	}
	public void Turning(Vector3 d){
		Quaternion	newRotation=Quaternion.LookRotation(d);
		transform.rotation=newRotation;
	}
}
