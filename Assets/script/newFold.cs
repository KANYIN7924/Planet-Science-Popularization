using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class newFold : MonoBehaviour
{
  // public RectTransform btnFold;
    public float xZvalue=1000f;
    public Transform obje;
    public GameObject btnPlanet;
    public Button hide;
    public Button show;

    public GameObject TextSystem;
    public GameObject solarSystem;
    private void Start()
    {
        btnPlanet.SetActive(false);
        hide.gameObject.SetActive(false);
    }
        
    void Update()
    {
        
    }

    public void BtnFold()
    {
        //btnFold[0].Rotate(xZvalue, 0, 0);
        btnPlanet.SetActive(true);

        transform.DOMove(obje.position, 2f);
        
        hide.gameObject.SetActive(true);
        show.gameObject.SetActive(false);
        TextSystem.SetActive(false);
        solarSystem.SetActive(false);
    }
    public void BtnHide()
    {
            transform.DOMove(-obje.position, 2f);
        

            btnPlanet.SetActive(false);
            show.gameObject.SetActive(true);
        TextSystem.SetActive(true);
        solarSystem.SetActive(true);
    }
}
