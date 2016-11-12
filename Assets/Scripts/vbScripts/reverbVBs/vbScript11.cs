using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript11 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject slider;
	private AudioReverbFilter reverb;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton11");

		arCam = GameObject.Find ("ARCamera");

		slider = GameObject.Find ("reverbSlider");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		transform.position = new Vector3 (0, 0,0);

		onButton = GameObject.Find ("Cube (11)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (slider.transform.position.z >= -.6f) 

		{
			slider.transform.Translate (0f, 0f, -.1f);

			arCam.GetComponent<AudioReverbFilter>  ().decayTime -= 2f;
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;


	}

}
