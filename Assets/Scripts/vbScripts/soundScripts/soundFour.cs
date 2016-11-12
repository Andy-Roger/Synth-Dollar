using UnityEngine;
using System.Collections;
using Vuforia;

public class soundFour : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	public AudioClip sound4;
	AudioSource zero;
	AudioSource one;
	AudioSource two;
	AudioSource three;
	AudioSource four;
	AudioSource five;
	AudioSource six;
	AudioSource seven;
	GameObject bCube1;
	GameObject bCube2;
	GameObject bCube3;
	GameObject bCube4;

	void Start () 
	{

		bCube1 = GameObject.Find ("babyCube1");
		bCube2 = GameObject.Find ("babyCube2");
		bCube3 = GameObject.Find ("babyCube3");
		bCube4 = GameObject.Find ("babyCube4"); 

		vbButtonObject = GameObject.Find ("soundFour");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		onButton = GameObject.Find ("Cube soundFour");

		AudioSource[] allMyAudioSources = GetComponents<AudioSource>();

		zero = allMyAudioSources [0];
		one = allMyAudioSources [1];
		two = allMyAudioSources [2];
		three = allMyAudioSources [3];
		four = allMyAudioSources [4];
		five = allMyAudioSources [5];
		six = allMyAudioSources [6];
		seven = allMyAudioSources [7];

	}


	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Bxxxokxokxokxokxoskxosxksokxsokx");

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		zero.clip = sound4;

		one.clip = sound4;

		two.clip = sound4;

		three.clip = sound4;

		four.clip = sound4;

		five.clip = sound4;

		six.clip = sound4;

		seven.clip = sound4;
			

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}

}
