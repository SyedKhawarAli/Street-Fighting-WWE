using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickController2 : MonoBehaviour {

	public float speed = 10f;
	Animator myAnimator;
	// Use this for initialization
	void Start () {
		myAnimator = this.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetAxis ("Horizontal2") != 0) {
			if (Input.GetAxis ("Horizontal2") > 0) {
				myAnimator.SetBool ("forward", true);
			} else if (Input.GetAxis ("Horizontal2") < 0) {
				myAnimator.SetBool ("backward", true);
			} else {
				myAnimator.SetBool ("idle", true);
			}
			print ("value: " + Input.GetAxis ("Horizontal2"));
			transform.localPosition += Input.GetAxis ("Horizontal2") * transform.right * Time.deltaTime * speed;
		}
		// if (Input.GetAxis ("Vertical2") != 0)
		// 	transform.localPosition += Input.GetAxis ("Vertical2") * transform.forward * Time.deltaTime * speed;

		// first controller buttons

		if (Input.GetButtonDown ("Fire1")) {
			print ("fire1");
		}
		if (Input.GetButtonDown ("Fire2")) {
			print ("fire2");
		}
		if (Input.GetButtonDown ("Fire3")) {
			print ("fire3");
		}
		if (Input.GetButtonDown ("Fire4")) {
			print ("fire4");
		}
		if (Input.GetButtonDown ("Fire5")) {
			print ("fire5");
		}
		if (Input.GetButtonDown ("Fire6")) {
			print ("fire6");
		}
		if (Input.GetButtonDown ("Fire7")) {
			print ("fire7");
		}
		if (Input.GetButtonDown ("Fire8")) {
			print ("fire8");
		}

		/// 2nd controller buttons

		// if (Input.GetButtonDown ("C2Fire1")) {
		// 	print ("fire1");
		// }
		// if (Input.GetButtonDown ("C2Fire2")) {
		// 	print ("fire2");
		// }
		// if (Input.GetButtonDown ("C2Fire3")) {
		// 	print ("fire3");
		// }
		// if (Input.GetButtonDown ("C2Fire4")) {
		// 	print ("fire4");
		// }
		// if (Input.GetButtonDown ("C2Fire5")) {
		// 	print ("fire5");
		// }
		// if (Input.GetButtonDown ("C2Fire6")) {
		// 	print ("fire6");
		// }
		// if (Input.GetButtonDown ("C2Fire7")) {
		// 	print ("fire7");
		// }
		// if (Input.GetButtonDown ("C2Fire8")) {
		// 	print ("fire8");
		// }

	}
}