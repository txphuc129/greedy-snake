using UnityEngine; 
using System.Collections;

public class TurnPoint : MonoBehaviour {

	ArrayList bodys;
	GameObject player;
	void Awake(){
		bodys=new ArrayList();
		player=GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		BodyMovement bodyMovement=other.gameObject.GetComponent<BodyMovement>();
		if(bodyMovement){
			for(int i=0;i<bodys.Count;i++){
				if(other==bodys[i]) return;
			}

			bodyMovement.gameObject.transform.position=transform.position;
			bodyMovement.Turning(transform.forward);
			bodys.Add(other);
			if(bodys.Count==player.GetComponent<PlayerAddBody>().bodys.Count){
				Destroy(gameObject);
			}
		}
		
	}
}
