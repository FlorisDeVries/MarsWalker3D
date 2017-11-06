using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClickAble : MonoBehaviour {
	public float points = 1;
	public virtual void OnClick(){
		GetComponent<MeshRenderer>().enabled = false;
	}

}
