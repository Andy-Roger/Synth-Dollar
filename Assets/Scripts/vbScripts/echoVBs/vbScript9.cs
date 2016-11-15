using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript9 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject slider;
	private AudioEchoFilter echo;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton9");

		arCam = GameObject.Find ("ARCamera");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		slider = GameObject.Find ("echoSlider");

		transform.position = new Vector3 (0, 0, 0);

		onButton = GameObject.Find ("Cube (9)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (slider.transform.position.z <= 0.013f) 

		{
			slider.transform.Translate (0f, 0f, .1f);

			arCam.GetComponent<AudioEchoFilter> ().delay += 300f;
		}
			
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	
	}

}
