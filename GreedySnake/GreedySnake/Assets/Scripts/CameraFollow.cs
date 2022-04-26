﻿using UnityEngine; 
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing=5f;
	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset=transform.position-target.position;
	}
	
	void FixedUpdate () {
		Vector3 targetCameraPosition=target.position+offset;
		transform.position=Vector3.Lerp(transform.position,targetCameraPosition,smoothing*Time.deltaTime);
	}
}
