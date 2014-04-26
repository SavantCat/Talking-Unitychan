using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class agent : MonoBehaviour {
	public GameObject model;
	public Julius_Client julius = null;
	public AudioClip[] clips;
	public string[]	command;
	public string[] triggers;

	private Animator animator;
	private AudioSource voice;
	// Use this for initialization
	void Start () {
		animator = model.GetComponent<Animator>();
		voice = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(clips != null && command != null){
			for(int i=0;i<command.Length;i++){
				if(command[i] == julius.Result){
					animator.SetBool(triggers[i],true);
					voice.clip = clips[i];
					voice.Play();
				}else{
					animator.SetBool(triggers[i],false);
				}
				//voice.clip = null;
			}
		}
	}
}
