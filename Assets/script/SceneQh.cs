using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneQh : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 4.0f;
    public new Text name;
    public Text nameTwo;
    public Text nameThree;
    public Text SuSahn;

    public float times;

    public Button start;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(sceneQ);

        name.gameObject.transform.DOMove(nameTwo.transform.position,2f);

    }

    // Update is called once per frame
    void Update()
    {
       // Scene sce = SceneManager.GetActiveScene();
        timer -= Time.deltaTime;
         times = Time.time;
            if (timer <= 0)
            {
                Debug.Log(string.Format("Timer1 is up !!! time=${0}", times));
                timer = 1.0f;
                if (times > 3)
                {

                    name.gameObject.transform.DOMove(nameThree.transform.position, 1f);
               
                }
            }
        if (timer > 10||times>10||Time.time>10)
        {
            name.gameObject.SetActive(false);
        }
    }
void sceneQ()
    {
        times = 1.1f;
        SceneManager.LoadScene("Observe");
    }

    public void Waring()
    {
        start.gameObject.SetActive(false);
        SuSahn.gameObject.SetActive(true);
    }
    public void CloseText()
    {
        start.gameObject.SetActive(true);
        SuSahn.gameObject.SetActive(false);
    }
    public void Eixt()
    {
        
        Application.Quit();
    }
}
