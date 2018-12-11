 using System.Collections.Generic;
 using System.Collections;
 using UnityEngine;

 public class playerController1 : MonoBehaviour {

 	public float moveSpeed;
 	private Rigidbody rigidbody;
 	private Animator animator;
 	public Transform player2;

 	private bool isPlayerGetHit = false;
 	float punchDamage = 1f;

 	// Use this for initialization
 	void Start () {
 		rigidbody = GetComponent<Rigidbody> ();
 		animator = GetComponent<Animator> ();
 		GameObject player = GameObject.FindGameObjectWithTag ("player2");
 		player2 = player.transform;
 	}

 	// Update is called once per frame
 	void Update () {
 		float movement = Input.GetAxis ("Horizontal");
 		rigidbody.velocity = new Vector3 (-moveSpeed * Time.deltaTime * movement, rigidbody.velocity.y, rigidbody.velocity.z);
 		animator.SetFloat ("forward", movement);
 		if (movement == 0) {
 			animator.SetBool ("idle", true);
 		} else {
 			animator.SetBool ("idle", false);

 		}
 		if (player2.position.x < transform.position.x) {
 			transform.localScale = new Vector3 (1, 1, -1);
 		} else {
 			transform.localScale = new Vector3 (1, 1, 1);
 		}

 		// fight animation 
 		if (Input.GetButtonDown ("Fire1")) {
 			print ("fire1");
 			animator.SetBool ("LPunch", true);
 			if (isPlayerGetHit) {
 				this.GetComponent<playerHealthManger> ().getDamage (punchDamage);
 			}
 		} else {
 			animator.SetBool ("LPunch", false);
 		}
 		if (Input.GetButtonDown ("Fire2")) {
 			print ("fire2");
 			animator.SetBool ("punch", true);
 		} else {
 			animator.SetBool ("punch", false);
 		}
 		if (Input.GetButtonDown ("Fire3")) {
 			print ("fire3");
 			animator.SetBool ("kick", true);
 		} else {
 			animator.SetBool ("kick", false);
 		}
 		if (Input.GetButtonDown ("Fire4")) {
 			print ("fire4");
 			animator.SetBool ("LKick", true);
 		} else {
 			animator.SetBool ("LKick", false);
 		}
 		if (Input.GetButtonDown ("Fire5")) {
 			print ("fire5");
 			animator.SetBool ("cumboShot", true);
 		} else {
 			animator.SetBool ("cumboShot", false);
 		}
 		if (Input.GetButtonDown ("Fire6")) {
 			print ("fire6");
 			animator.SetBool ("LKick", true);
 		} else {
 			animator.SetBool ("LKick", false);
 		}
 		if (Input.GetButtonDown ("Fire7")) {
 			print ("fire7");
 			animator.SetBool ("LKick", true);
 		} else {
 			animator.SetBool ("LKick", false);
 		}
 		if (Input.GetButtonDown ("Fire8")) {
 			print ("fire8");
 			animator.SetBool ("LKick", true);
 		} else {
 			animator.SetBool ("LKick", false);
 		}
 	}
 }