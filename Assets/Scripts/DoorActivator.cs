using UnityEngine;
using System.Collections;

public class DoorActivator : MonoBehaviour {

	private Animator animator;
	public GameObject cage;

	void Awake () {
		animator = GetComponent <Animator>();
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			animator.SetBool ("Open", true);
		}


	}
	
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
			animator.SetBool ("Open", false);
		}

	}
	
}