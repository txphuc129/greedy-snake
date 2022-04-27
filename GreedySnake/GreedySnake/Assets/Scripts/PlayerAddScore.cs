using UnityEngine; 
using System.Collections;
using UnityEngine.UI;

public class PlayerAddScore : MonoBehaviour {

	public Text textField;
	int score;
	// Use this for initialization
	void Start () {
		score=0;
		textField.text="Score: "+score;
	}
	public void AddScore(){
		score++;
		textField.text="Score: "+score;
	}
}
