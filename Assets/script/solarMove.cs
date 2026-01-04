using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class solarMove : MonoBehaviour
{
    public Transform[] uiMove;
    public GameObject[] uiTwo;

    public GameObject TextSystem;

    public Button show;
    public Button hide;

    public GameObject yuanTwo;

    public GameObject guideText;
    public void BtnShow()
    {
        guideText.SetActive(false);
        
          GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
       // GameObject.Find("yuan").GetComponent<UIrotate>().enabled = false;

        #region
        GameObject.Find("sun").GetComponent<Rotate>().enabled = false;
        GameObject.Find("mercury").GetComponent<Rotate>().enabled = false;
        GameObject.Find("mercury").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("venus").GetComponent<Rotate>().enabled = false;
        GameObject.Find("venus").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("EarthHigh").GetComponent<Rotate>().enabled = false;
        GameObject.Find("EarthHigh").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("mars").GetComponent<Rotate>().enabled = false;
        GameObject.Find("mars").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("jupiter").GetComponent<Rotate>().enabled = false;
        GameObject.Find("jupiter").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("saturn").GetComponent<Rotate>().enabled = false;
        GameObject.Find("saturn").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("uranus").GetComponent<Rotate>().enabled = false;
        GameObject.Find("uranus").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("neptune").GetComponent<Rotate>().enabled = false;
        GameObject.Find("neptune").GetComponent<SpinFree>().enabled = false;
        GameObject.Find("moon").GetComponent<Rotate>().enabled = false;
        GameObject.Find("moon").GetComponent<SpinFree>().enabled = false;
        #endregion

        #region
        uiMove[0].DOMove(uiTwo[0].transform.position, 0.7f);
        uiMove[1].DOMove(uiTwo[1].transform.position, 1.1f);
        uiMove[2].DOMove(uiTwo[2].transform.position, 1.2f);
        uiMove[3].DOMove(uiTwo[3].transform.position, 1.3f);
        uiMove[4].DOMove(uiTwo[4].transform.position, 1.4f);
        uiMove[5].DOMove(uiTwo[5].transform.position, 1.5f);
        uiMove[6].DOMove(uiTwo[6].transform.position, 1.6f);
        uiMove[7].DOMove(uiTwo[7].transform.position, 1.7f);
        uiMove[8].DOMove(uiTwo[8].transform.position, 1.8f);
        #endregion
        TextSystem.SetActive(false);

        show.gameObject.SetActive(false);
        hide.gameObject.SetActive(true);
        yuanTwo.SetActive(true);
    }
  
   public void BtnHide()
    {
        guideText.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;

      //  GameObject.Find("yuan").GetComponent<UIrotate>().enabled = true;
        #region
        GameObject.Find("sun").GetComponent<Rotate>().enabled = true;
       
        GameObject.Find("mercury").GetComponent<Rotate>().enabled = true;
        GameObject.Find("mercury").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("venus").GetComponent<Rotate>().enabled = true;
        GameObject.Find("venus").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("EarthHigh").GetComponent<Rotate>().enabled = true;
        GameObject.Find("EarthHigh").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("mars").GetComponent<Rotate>().enabled = true;
        GameObject.Find("mars").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("jupiter").GetComponent<Rotate>().enabled = true;
        GameObject.Find("jupiter").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("saturn").GetComponent<Rotate>().enabled = true;
        GameObject.Find("saturn").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("uranus").GetComponent<Rotate>().enabled = true;
        GameObject.Find("uranus").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("neptune").GetComponent<Rotate>().enabled = true;
        GameObject.Find("neptune").GetComponent<SpinFree>().enabled = true;
        GameObject.Find("moon").GetComponent<Rotate>().enabled = true;
        GameObject.Find("moon").GetComponent<SpinFree>().enabled = true;
        #endregion
        #region
        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1.2f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1.4f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1.6f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1.8f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 2.0f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 2.2f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 2.4f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 2.6f);
        #endregion
        
        TextSystem.SetActive(true);

        hide.gameObject.SetActive(false);
        show.gameObject.SetActive(true);
        yuanTwo.SetActive(false);
    }
}
