using UnityEngine;
using System.Collections;
using Vuforia;

public class soundTwo : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	public AudioClip sound2;
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

		vbButtonObject = GameObject.Find ("soundTwo");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		onButton = GameObject.Find ("Cube soundTwo");

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

		zero.clip = sound2;

		one.clip = sound2;

		two.clip = sound2;

		three.clip = sound2;

		four.clip = sound2;

		five.clip = sound2;

		six.clip = sound2;

		seven.clip = sound2;

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}

}
