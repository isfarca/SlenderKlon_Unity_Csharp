using UnityEngine;
using System.Collections;

public class BatterienManager : MonoBehaviour 
{
	public GameObject Batterien; // Intelligenz für Batterien

	// Use this for initialization
	void Start () 
	{
		int AnzahlBatterien = 0;
		GameObject Batteriepackung;
		Vector3 Position;

		while(AnzahlBatterien < 100) // 99 Batterien werden gespawnt 
		{
			Position = new Vector3(Zufall(100, 1700), 0.048f, Zufall(100, 1700)); // x-, y-, z-Achsen
			Batteriepackung = (GameObject)Instantiate(Batterien, Position, Quaternion.identity); // Batterienspawn
			// Batterien werden in der Spielwelt vorübergehend gespeichert
			Batteriepackung.tag = "Batteriepackung";
			Batteriepackung.transform.parent = gameObject.transform;
			Batteriepackung.AddComponent<BatteriepackungLogik>(); // Zu jeder Batterie wird dieser Skript angehängt
			AnzahlBatterien++;
		}
	}

	float Zufall(int Minimum, int Maximum)
	{
		return(float)Random.Range(Minimum, Maximum); // Random gibt Double-Werte zurück 
	}

	// Update is called once per frame
	void Update () 
	{
	}
}