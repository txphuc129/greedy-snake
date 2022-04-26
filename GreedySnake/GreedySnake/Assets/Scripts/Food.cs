using UnityEngine; 
using System.Collections;

public class Food : MonoBehaviour {
	public GameObject body;
	public CreateFood createFood;
	
	GameObject  player;
	bool isTrigger=false;
	void Awake(){
		player=GameObject.FindGameObjectWithTag("Player");
	} 
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 50 * Time.deltaTime, 0);
	}
	void OnTriggerEnter(Collider other){
		if(isTrigger) return;
		if(other.gameObject==player){
			isTrigger=true;
			Destroy(this.gameObject);
			AddBody();
			createFood.AddFood();
		}else{
			isTrigger=true;
			Destroy(this.gameObject);
			createFood.AddFood();
		}

	}
	void AddBody(){
		ArrayList temp=player.GetComponent<PlayerAddBody>().bodys;
		GameObject b=temp[temp.Count-1] as GameObject;
		GameObject addBody=Instantiate(body,b.transform.position-b.transform.forward*1.5f,b.transform.rotation) as GameObject;
		temp.Add(addBody);
		player.GetComponent<PlayerAddScore>().AddScore();
		player.GetComponent<PlayerMovement>().AddSpeed();
	}
}
