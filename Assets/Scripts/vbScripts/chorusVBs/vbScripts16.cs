using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScripts16 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject chorusOnText;
	private GameObject chorusOffText;
	private float chorusToggle;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton16");

		arCam = GameObject.Find ("ARCamera");

		chorusOnText = GameObject.Find ("on_chorus");

		chorusOffText = GameObject.Find ("off_chorus");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		transform.position = new Vector3 (0, 0,0);

		onButton = GameObject.Find ("Cube (16)");

		chorusToggle = 1f;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (chorusToggle >= 1f) {

			chorusToggle = 0f;

			arCam.GetComponent<AudioChorusFilter> ().enabled = true;

			chorusOnText.transform.localScale += new Vector3 (.4f, 1f, 1f);

			chorusOffText.transform.localScale -= new Vector3 (.4f, 1f, 1f);
		} 

		else
		{
			chorusToggle = 1f;

			arCam.GetComponent<AudioChorusFilter> ().enabled = false;

			chorusOnText.transform.localScale -= new Vector3 (.4f, 1f, 1f);

			chorusOffText.transform.localScale += new Vector3 (.4f, 1f, 1f);
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}

}
