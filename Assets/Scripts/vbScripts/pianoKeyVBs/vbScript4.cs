using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript4 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject pianoKey;
	public AudioSource note4;
	public float halfStep = 1.059463094359f; 
	private float startingPitch = 1f;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton4");

		pianoKey = GameObject.Find ("Cube (4)");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is pressed!!!");

		note4.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

		pianoKey.GetComponent<MeshRenderer> ().enabled = false;

		note4.Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = true;

	}
}
