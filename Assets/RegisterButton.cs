using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterButton : MonoBehaviour {

	public GameObject thisObj;
	public GameObject subObj;

	public void OnClickButton()
	{

		Vector3 a = thisObj.transform.position;
		a.y += 552;
		thisObj.transform.position = a;

		Vector3 b = subObj.transform.position;
		b.y += 552;
		subObj.transform.position = b;
	}
}
