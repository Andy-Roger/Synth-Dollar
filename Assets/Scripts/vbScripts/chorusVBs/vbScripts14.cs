using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScripts14 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject slider;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton14");

		arCam = GameObject.Find ("ARCamera");

		slider = GameObject.Find ("chorusSlider");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		transform.position = new Vector3 (0, 0,0);

		onButton = GameObject.Find ("Cube (14)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (slider.transform.position.z >= -.6f) 

		{
			slider.transform.Translate (0f, 0f, -.1f);

			arCam.GetComponent<AudioChorusFilter>  ().depth -= .143f;
		}
	}

	void Update ()
	{
		if (slider.transform.position.z >=  -.6f) 

		{
			arCam.GetComponent<AudioChorusFilter>  ().enabled = true;
		}

		if (slider.transform.position.z <= -.6f) 

		{
			arCam.GetComponent<AudioChorusFilter>  ().enabled = false;
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;


	}

}
