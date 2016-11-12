using UnityEngine;
using System.Collections;

public class monoStereoTog : MonoBehaviour {

	float tog;
	GameObject Cam;
	GameObject Cam1;

	// Use this for initialization
	void Start () {
		tog = 1f;
		Cam = GameObject.Find ("Camera");
		Cam1 = GameObject.Find ("Camera1");

		Cam.GetComponent<Camera> ().rect = new Rect(0f, 0f, 1f, 1f);
		Cam1.GetComponent<Camera> ().rect = new Rect(0f, 0f, 0f, 0f);
	
	}
	
	// Update is called once per frame
	public void monoToStereoToggle () {

		if (tog >= 1f) {
			Cam.GetComponent<Camera> ().rect = new Rect (0f, 0f, .5f, 1f);
			Cam1.GetComponent<Camera> ().rect = new Rect (.5f, 0f, .5f, 1f);


			tog = 0f;
		} 
		else
		{
			Cam.GetComponent<Camera> ().rect = new Rect (0f, 0f, 1f, 1f);
			Cam1.GetComponent<Camera> ().rect = new Rect (0f, 0f, 0f, 0f);
			tog = 1f;
		}
	}
}
