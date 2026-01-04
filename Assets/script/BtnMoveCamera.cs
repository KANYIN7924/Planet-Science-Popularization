using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BtnMoveCamera : MonoBehaviour
{
   public GameObject mainCamera;
   public GameObject[] allCamera;

    public Transform[] uiMove;
    public GameObject[] uiTwo;


   // public Button hide;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame

    public void mainCamT()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);
    }
    public void btnSun()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(true);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("sun").GetComponent<Rotate>().enabled = true;


        uiMove[0].DOMove(uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);

        for (int i = 0; i < uiTwo.Length; i++)
        {
            if (uiTwo[i].transform.position==-uiTwo[i].transform.position)
            {
                print("???");
                uiTwo[-i].SetActive(false);
            }
        }
    }
    public void btnMercury()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(true);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("mercury").GetComponent<Rotate>().enabled = true;
        GameObject.Find("mercury").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);

    }
    public void btnVenus()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(true);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("venus").GetComponent<Rotate>().enabled = true;
        GameObject.Find("venus").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);
    }
    public void btnEarth()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(true);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("EarthHigh").GetComponent<Rotate>().enabled = true;
        GameObject.Find("EarthHigh").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);
    }
    public void btnMars()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(true);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("mars").GetComponent<Rotate>().enabled = true;
        GameObject.Find("mars").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);
    }
   public void btnJupiter()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(true);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("jupiter").GetComponent<Rotate>().enabled = true;
        GameObject.Find("jupiter").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);
    }
    public void btnStaurn()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(true);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(false);

        GameObject.Find("saturn").GetComponent<Rotate>().enabled = true;
        GameObject.Find("saturn").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);
    }
    public void btnUranus()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(true);
        allCamera[8].SetActive(false);

        GameObject.Find("uranus").GetComponent<Rotate>().enabled = true;
        GameObject.Find("uranus").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(-uiTwo[8].transform.position, 1f);
    }
    public void btnNeptune()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;

        allCamera[0].SetActive(false);
        allCamera[1].SetActive(false);
        allCamera[2].SetActive(false);
        allCamera[3].SetActive(false);
        allCamera[4].SetActive(false);
        allCamera[5].SetActive(false);
        allCamera[6].SetActive(false);
        allCamera[7].SetActive(false);
        allCamera[8].SetActive(true);

        GameObject.Find("neptune").GetComponent<Rotate>().enabled = true;
        GameObject.Find("neptune").GetComponent<SpinFree>().enabled = true;

        uiMove[0].DOMove(-uiTwo[0].transform.position, 1f);
        uiMove[1].DOMove(-uiTwo[1].transform.position, 1f);
        uiMove[2].DOMove(-uiTwo[2].transform.position, 1f);
        uiMove[3].DOMove(-uiTwo[3].transform.position, 1f);
        uiMove[4].DOMove(-uiTwo[4].transform.position, 1f);
        uiMove[5].DOMove(-uiTwo[5].transform.position, 1f);
        uiMove[6].DOMove(-uiTwo[6].transform.position, 1f);
        uiMove[7].DOMove(-uiTwo[7].transform.position, 1f);
        uiMove[8].DOMove(uiTwo[8].transform.position, 1f);
    }
}
