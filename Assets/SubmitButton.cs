using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitButton : MonoBehaviour {

	public GameObject thisObj;
	public GameObject subObj;
	public GameObject InputText;
	public GameObject resultTextBox;

	// Use this for initialization
	public void OnClickButton()
	{
		string input = InputText.GetComponent<Text>().text;
		if (input != "")
		{
			Vector3 a = thisObj.transform.position;
			a.y -= 552;
			thisObj.transform.position = a;

			Vector3 b = subObj.transform.position;
			b.y -= 552;
			subObj.transform.position = b;
			
			TextBox sc = resultTextBox.GetComponent<TextBox>();
			sc.ScoreSubmit(input, Random.Range(0, 1000) * Random.Range(0, 1000));
			InputText.GetComponent<Text>().text = "";
		}
	}
}
