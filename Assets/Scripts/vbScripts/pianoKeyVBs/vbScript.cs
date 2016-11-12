using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject pianoKey;
	public AudioSource note;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		pianoKey = GameObject.Find ("Cube (0)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("actionButton is pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = false;

		note.Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = true;

	}

}
