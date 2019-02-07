using UnityEngine;
using System.Collections;

public class SlenderKI : MonoBehaviour 
{
	public static float Abhängigkeit;
	private bool Erscheinen;

	// Use this for initialization
	void Start () 
	{
		Erscheinen = false; // Spieler soll den Slender am Anfang nicht sehen
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 Position = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 Rotation = GameObject.FindGameObjectWithTag("Player").transform.rotation.eulerAngles;
		float Grad = Mathf.PI / 180f; // Werte als Gradzahl für kleinere Zahlen

		if(!Erscheinen) 
		{
			gameObject.transform.position = new Vector3(Position.x + 10f * Mathf.Sin((Rotation.y + 180f) * Grad), 2.76f, Position.z + 10f * Mathf.Cos((Rotation.y + 180f) * Grad)); // x-, y-, z-Achsen
		}

		if(Abhängigkeit < 0)
			Abhängigkeit = 0;

		Erschrecken();
	}

	// Bei welchen Abhängigkeitswerten der Slender erscheinen soll oder nicht erscheinen soll (provisorisch)
	void Erschrecken ()
	{
		if(Abhängigkeit > 0.3 && Abhängigkeit < 0.6)
			Erscheinen = true;
		if(Abhängigkeit > 0.1 && Abhängigkeit < 0.3)
			Erscheinen = false;
		if(Abhängigkeit > 0.6 && Abhängigkeit < 0.9)
			Erscheinen = false;
		if(Abhängigkeit > 0.9)
			Erscheinen = true;
	}
}
