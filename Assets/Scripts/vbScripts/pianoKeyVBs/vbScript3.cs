using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript3 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject pianoKey;
	public AudioSource note3;
	private float halfStep = 1.059463094359f; 
	private float startingPitch = 1f;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton3");

		pianoKey = GameObject.Find ("Cube (3)");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("actionButton3 is pressed!!!");

		note3.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep);

		pianoKey.GetComponent<MeshRenderer> ().enabled = false;

		note3.Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = true;

	}
}
