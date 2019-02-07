using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeitenManager : MonoBehaviour
{
    private GameObject[] ErscheinenListe;
    private GameObject[] Seiten;

    public GameObject[] Originale;

	// Use this for initialization
	void Start ()
    {
        int Ort;
        GameObject Erscheinen;

        ErscheinenListe = GameObject.FindGameObjectsWithTag("SeiteErscheinen");
        Seiten = new GameObject[8];

        for (int i = 0; i < Seiten.Length; i++)
        {
            Ort = (int)Random.Range(0, ErscheinenListe.Length - 1);

            while (ErscheinenListe[Ort] = null)
                Ort = (int)Random.Range(0, ErscheinenListe.Length - 1);

            Erscheinen = ErscheinenListe[Ort];
            Seiten[i] = Instantiate(Originale[i], Erscheinen.gameObject.transform.position, Erscheinen.gameObject.transform.rotation); // NullReferenceException
            ErscheinenListe[Ort] = null;
            Seiten[i].AddComponent<SeiteAufnehmen>();
        }
	}
}
