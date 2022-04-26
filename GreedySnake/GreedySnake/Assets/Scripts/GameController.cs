using UnityEngine; 
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void LoadScene02(){
		Application.LoadLevel("Scene01");
	}
	public void ExitGame(){
		Application.Quit();
	}
	public void LoadSceneHelp(){
		Application.LoadLevel("SceneHelp");
	}
	public void LoadSceneMenu(){
		Application.LoadLevel("SceneMenu");
	}
}
