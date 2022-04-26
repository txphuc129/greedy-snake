using UnityEngine; 
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public GameObject turnPoint;
	public GameObject body;
	public bool isDead;
	public bool isRandomMoving;

	int derection=1;
	Quaternion newRotation;

	void Awake(){
		speed=7f;
		if(isRandomMoving){
			InvokeRepeating("RandomMoving",1f,1.5f);
		}

	}
	void RandomMoving(){
		derection=derection%6+1;
		
	}
	void Update(){
		if(isDead) return;
		if(Input.GetKeyDown(KeyCode.W)&&derection!=4){
			derection=1;
		}
		if(Input.GetKeyDown(KeyCode.A)&&derection!=2){
			derection=5;
		}
		if(Input.GetKeyDown(KeyCode.S)&&derection!=1){
			derection=4;
		}
		if(Input.GetKeyDown(KeyCode.D)&&derection!=5){
			derection=2;
		}
		if(Input.GetKeyDown(KeyCode.Q)&&derection!=6){
			derection=3;
		}
		if(Input.GetKeyDown(KeyCode.E)&&derection!=3){
			derection=6;
		}
		transform.position=body.transform.position+body.transform.forward;
	}
	void FixedUpdate(){
		if(isDead) return;
		Moving();
		Turning();
	}
	void Moving(){

		transform.position+=transform.forward*speed*Time.deltaTime;
	}
	void Turning(){

		switch(derection){
			case 1:
				if(transform.forward==Vector3.forward) return;
				newRotation=Quaternion.LookRotation(Vector3.forward);
				transform.rotation=newRotation;
				SetTurnPoint(transform.position,newRotation);
				//transform.position+=Vector3.forward;
				transform.position+=transform.forward;
				break;
			case 2:
				if(transform.forward==Vector3.right) return;
				newRotation=Quaternion.LookRotation(Vector3.right);
				transform.rotation=newRotation;
				SetTurnPoint(transform.position,newRotation);
				//transform.position+=Vector3.right;
				transform.position+=transform.forward;
				break;
			case 4:
				if(transform.forward==-Vector3.forward) return;
				newRotation=Quaternion.LookRotation(-Vector3.forward);
				transform.rotation=newRotation;
				SetTurnPoint(transform.position,newRotation);
				//transform.position-=Vector3.forward;
				transform.position+=transform.forward;
				break;
			case 5:
				if(transform.forward==Vector3.left) return;
				newRotation=Quaternion.LookRotation(Vector3.left);
				transform.rotation=newRotation;
				SetTurnPoint(transform.position,newRotation);
				//transform.position+=Vector3.left;
				transform.position+=transform.forward;
				break;
			case 3:
				if(transform.forward==Vector3.up) return;
				newRotation=Quaternion.LookRotation(Vector3.up);
				transform.rotation=newRotation;
				SetTurnPoint(transform.position,newRotation);
				transform.position+=transform.forward;
				break;
			case 6:
				if(transform.forward==Vector3.down) return;
				newRotation=Quaternion.LookRotation(Vector3.down);
				transform.rotation=newRotation;
				SetTurnPoint(transform.position,newRotation);
				transform.position+=transform.forward;
				break;
		}
	}

	void SetTurnPoint(Vector3 position,Quaternion rotation){
		Instantiate(turnPoint,position,rotation);
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject==body||other.gameObject.GetComponent<Food>()) return;
		isDead=true;
		Invoke("Replay",1f);
	}
	public void AddSpeed(){
		speed+=0.25f;
	}
	void Replay(){
		Application.LoadLevel("SceneMenu");
	}
}
