using UnityEngine; 
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Vector3 offset;
	float speed;
	// Use this for initialization
	void Start () {
		offset=new Vector3(0,9f,-10f);
		speed=0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		speed++;
		offset.Set(0,Mathf.Sin(speed*0.01f)*5f+9f,Mathf.Abs(Mathf.Cos(speed*0.01f)*20f)-30f);
		transform.position=offset;
	}
}
