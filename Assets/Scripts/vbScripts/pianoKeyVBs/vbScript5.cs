using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript5 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject pianoKey;
	public AudioSource note5;
	private float halfStep = 1.059463094359f; 
	private float startingPitch = 1f;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton5");

		pianoKey = GameObject.Find ("Cube (5)");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is pressed!!!");

		note5.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

		pianoKey.GetComponent<MeshRenderer> ().enabled = false;

		note5.Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = true;

	}
}
