using UnityEngine;
using System.Collections;

public class LevelFinished : MonoBehaviour {
	public GameObject pausedQuestionCanvas;
	// Use this for initialization
	void Start () {
		pausedQuestionCanvas.SetActive (false);
		GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.transform.position = new Vector3(60, 2F, 95);
		//sphere.tag = "LevelOver";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider hit){
		if (hit.CompareTag ("LevelOver")) {
			pausedQuestionCanvas.SetActive(true);
			Application.LoadLevel("scene_gameWon");
		}
	}

}
