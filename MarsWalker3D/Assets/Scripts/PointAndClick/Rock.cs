using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : ClickAble {

	void Start () {
		points = 5;
	}
	
	void Update () {
		
	}

	override public void OnClick(){
		//Play effect
		Destroy(gameObject);
	}
}
