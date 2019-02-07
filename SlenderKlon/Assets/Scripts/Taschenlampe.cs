using UnityEngine;
using System.Collections;

public class Taschenlampe : MonoBehaviour 
{
	public static float BatterieLebensDauer;
	public float Intensität;
	private bool TaschenlampeAN;

	// Use this for initialization
	void Start () 
	{
		BatterieLebensDauer = 1f;
        Intensität = 1f;
		TaschenlampeAN = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel") < 0) // Wenn der Scroller runtergescrollt wird, dann wird die Intensivität erniedrigt
            Intensität -= 0.05f;
		else if(Input.GetAxis("Mouse ScrollWheel") > 0) // Wenn der Scroller hochgescrollt wird, dann wird die Intensivität erhöht
            Intensität += 0.05f;

		if(TaschenlampeAN) 
		{
			BatterieLebensDauer -= (Time.deltaTime / 50) * Intensität / 2;
			SlenderKI.Abhängigkeit -= Time.deltaTime / 60;
		}
		else if(!TaschenlampeAN)
			SlenderKI.Abhängigkeit += Time.deltaTime / 30;

        if (BatterieLebensDauer > 0)
            gameObject.GetComponent<Light>().intensity = BatterieLebensDauer * Intensität;

		// Ein- und Ausschalten der Taschenlampe mit linker Maustaste
		if(Input.GetButtonDown("Fire1")) 
		{
			gameObject.GetComponent<Light>().enabled = !gameObject.GetComponent<Light>().enabled;
			TaschenlampeAN = !TaschenlampeAN;
		}
	}
}
