using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnReal : MonoBehaviour
{
    public Button[] planetBtn;
    public Text[] planetIntroduce;
    public Button show;
    public Button hide;

    

    public Image icon;
    private void Start()
    {
        hide.onClick.AddListener(hideTextOrIcon);

        planetBtn[0].onClick.AddListener(sunBtn);
        planetBtn[1].onClick.AddListener(mercuryBtn);
        planetBtn[2].onClick.AddListener(venusBtn);
        planetBtn[3].onClick.AddListener(earthBtn);
        planetBtn[4].onClick.AddListener(marsBtn);
        planetBtn[5].onClick.AddListener(jupiterBtn);
        planetBtn[6].onClick.AddListener(saturnBtn);
        planetBtn[7].onClick.AddListener(uranusBtn);
        planetBtn[8].onClick.AddListener(neptuneBtn);




    }
    public void Seeting()
    {
        SceneManager.LoadScene(3);
    }
    void sunBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(239,104,8,255);
        planetIntroduce[0].gameObject.SetActive(true);
    }
    void mercuryBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(142, 152, 164, 255);
        planetIntroduce[1].gameObject.SetActive(true);
    }
    void venusBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(255, 105, 0, 255);
        planetIntroduce[2].gameObject.SetActive(true);
    }
    void earthBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(0, 120, 255, 255);
        planetIntroduce[3].gameObject.SetActive(true);
    }
    void marsBtn()
    {
        icon.gameObject.SetActive(true);
        //icon.color = new Color(255, 76, 52, 255);
        planetIntroduce[4].gameObject.SetActive(true);
    }
    void jupiterBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(197, 174, 139, 255);
        planetIntroduce[5].gameObject.SetActive(true);
    }
    void saturnBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(255, 105, 0, 255);
        planetIntroduce[6].gameObject.SetActive(true);
    }
    void uranusBtn()
    {
        icon.gameObject.SetActive(true);
        //icon.color = new Color(255, 105, 0, 255);
        planetIntroduce[7].gameObject.SetActive(true);
    }
    void neptuneBtn()
    {
        icon.gameObject.SetActive(true);
       // icon.color = new Color(255, 105, 0, 255);
        planetIntroduce[8].gameObject.SetActive(true);
    }
    void hideTextOrIcon()
    {
        icon.gameObject.SetActive(false);
       // icon.color = new Color(255, 255, 255, 255);
        planetIntroduce[0].gameObject.SetActive(false);
        planetIntroduce[1].gameObject.SetActive(false);
        planetIntroduce[2].gameObject.SetActive(false);
        planetIntroduce[3].gameObject.SetActive(false);
        planetIntroduce[4].gameObject.SetActive(false);
        planetIntroduce[5].gameObject.SetActive(false);
        planetIntroduce[6].gameObject.SetActive(false);
        planetIntroduce[7].gameObject.SetActive(false);
        planetIntroduce[8].gameObject.SetActive(false);
    }
}
