using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript12 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject slider;
	private AudioReverbFilter reverb;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton12");

		arCam = GameObject.Find ("ARCamera");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		slider = GameObject.Find ("reverbSlider");

		transform.position = new Vector3 (0, 0, 0);

		onButton = GameObject.Find ("Cube (12)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("reverb is disabled!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (slider.transform.position.z <= 0.013f) 

		{
			slider.transform.Translate (0f, 0f, .1f);

			arCam.GetComponent<AudioReverbFilter> ().decayTime += 2f;
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;


	}

}
