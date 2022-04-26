using UnityEngine;
using System.Collections; 

public class PlayerAddBody : MonoBehaviour {
	public ArrayList bodys;
	public GameObject body,body1,body2,body3,body4;
	void Awake(){
		bodys=new ArrayList();
		bodys.Add(body);
		bodys.Add(body1);
		if(body2) bodys.Add(body2);
		if(body3) bodys.Add(body3);
		if(body4) bodys.Add(body4);
	}

}
