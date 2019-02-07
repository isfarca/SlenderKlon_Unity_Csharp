using UnityEngine;
using System.Collections;

public class BatteriepackungLogik : MonoBehaviour 
{
	private GameObject Spieler;
	public float Zunahme;

	// Use this for initialization
	void Start () 
	{
		Zunahme = 0.001f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit Interaktion;
		Ray Linie = Camera.main.ScreenPointToRay(Input.mousePosition); // Richtung der unsichtbaren Linie

		if(Physics.Raycast(Linie, out Interaktion, 10)) // Information, die der Maus in 10cm aufnimmt, werden in Interaktion gespeichert
		{
			if(Interaktion.collider.tag == "Batteriepackung") // Prüft ob die Linie, das Objekt getroffen hat 
			{
				if(Input.GetButtonDown("Fire2")) // Aktion bei klicken der rechten Maustaste
				{
					Taschenlampe.BatterieLebensDauer += Zunahme;
					Destroy(Interaktion.collider.gameObject); 
				}
			}
		}
	}
}