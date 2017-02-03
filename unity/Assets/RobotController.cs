using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float vertAxis = Input.GetAxis ("Vertical");
		float horzAxis = Input.GetAxis ("Horizontal");
		if (vertAxis > 0.5) {
			// move forward
			transform.Translate(Vector3.right * Time.deltaTime * 8);
		} else if (vertAxis < -0.5) {
			// move back
			transform.Translate(Vector3.right * Time.deltaTime * -1 * 8);
		}
		if (horzAxis < -0.5) {
			// turn left
			transform.Rotate(new Vector3(0,-1 * Time.deltaTime * 150,0));
		} else if (horzAxis > 0.5) {
			// turn right
			transform.Rotate(new Vector3(0,1 * Time.deltaTime * 150,0));
		}
		bool btnA = Input.GetButton ("Fire1");
		//Debug.Log (vertAxis + " " + horzAxis + " " + btnA);


	}
}
