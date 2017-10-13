using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct Result
{
	public int Score;
	public string Name;
}

public class TextBox : MonoBehaviour {
	public List<Result> result = new List<Result>();

	public GameObject nameText;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 11; i++)
		{
			Result buf;
			buf.Name = "Name" + i;
			buf.Score = Random.Range(0, 1000) * Random.Range(0, 1000);
			result.Add(buf);
		}

		result.Sort((a, b) => a.Score.CompareTo(b.Score));

		UpdateText();
		
	}
	
	// Update is called once per frame
	void UpdateText () {
		string textall;
		textall = "";

		for (int i = 0; i < 10; i++)
		{
			textall += result[i].Score + "\n";
		}
		this.GetComponent<Text>().text = textall;

		textall = "";
		for (int i = 0; i < 10; i++)
		{
			textall += result[i].Name + "\n";
		}
		nameText.GetComponent<Text>().text = textall;
	}

	public void ScoreSubmit(string name, int s)
	{
		Result buf = result[10];
		buf.Score = s;
		buf.Name = name;
		result[10] = buf;

		result.Sort((a, b) => a.Score.CompareTo(b.Score));
		UpdateText();
	}
}
