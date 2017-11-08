using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : ClickAble {
	public AudioSource source;
	override public void OnClick(){
		source.Play();
		GetComponent<Renderer>().enabled = false;
		GetComponent<MeshCollider>().enabled = false;
		//Play effect
		Destroy(gameObject, source.clip.length);
	}
}
