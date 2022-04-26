using UnityEngine; 
using System.Collections;

public class CreateFood : MonoBehaviour {
	public GameObject food;

	void Start(){
		AddFood();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddFood(){
		//if(GameObject.FindGameObjectWithTag("Food")) return;
		Instantiate(food,new Vector3(Random.Range(-14,14),0.5f,Random.Range(-19,19)),food.transform.rotation);
	}
}
