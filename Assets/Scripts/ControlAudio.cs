using UnityEngine;
using System.Collections;

public class ControlAudio : MonoBehaviour {
	//public GameObject audioSource;//adding an audio source
	private bool sound = false;
	public AudioSource audioSource;
	// Use this for initialization
	void Start () {
		//audioSource.SetActive(true);
		AudioListener.volume = 1;
	}
	// Update is called once per frame
	//continue on to make the sound mute
	//try and make the code to make sure its adj and check pg  n unity in gg
	void OnGUI(){

//		sound = GUI.Toggle (sound);
		//if (sound = !sound) {
			if (sound == true) {
				AudioListener.volume = 0;
				//audioSource.mute = true;
				//audioSource.Play();
			} else {
				AudioListener.volume = 1;
				//	audioSource.SetActive(true);
			}
		//}
	}
}
