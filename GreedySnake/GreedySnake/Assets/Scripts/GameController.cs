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
		#if (UNITY_EDITOR || DEVELOPMENT_BUILD)
			Debug.Log(this.name+" : "+this.GetType()+" : "+System.Reflection.MethodBase.GetCurrentMethod().Name); 
		#endif
		#if (UNITY_EDITOR)
			UnityEditor.EditorApplication.isPlaying = false;
		#elif (UNITY_STANDALONE) 
			Application.Quit();
		#elif (UNITY_WEBGL)
			Application.OpenURL("about:blank");
		#endif
	}
	public void LoadSceneHelp(){
		Application.LoadLevel("SceneHelp");
	}
	public void LoadSceneMenu(){
		Application.LoadLevel("SceneMenu");
	}
}
