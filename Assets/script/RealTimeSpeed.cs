using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class RealTimeSpeed : MonoBehaviour
{
    public Image mImage;
   
    private int mOldAmount = 0;
    private int mNewAmount = 1;

    public Image spere;
    public Image spereTwo;
    private void Start()
    {
        spere.gameObject.transform.DOMove(spereTwo.transform.position, 7f);
    }
    private void OnEnable()
    {
        TweenImageFillAmount();
    }

    private void TweenImageFillAmount()
    {
        DOTween.To(delegate (float value)
        {

            mImage.fillAmount = value;
            if (mImage.fillAmount == 1)
            {
                spere.color = new Color(0, 0, 0, 0);
                SceneManager.LoadScene(2);
            }

        }, mOldAmount, mNewAmount, 7f);
    }

}