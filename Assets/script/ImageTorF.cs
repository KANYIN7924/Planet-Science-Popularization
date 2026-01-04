using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ImageTorF : MonoBehaviour
{
    public Image mImage;
    private int mOldAmount = 0;
    private int mNewAmount = 1;


    private void OnEnable()
    {
        TweenImageFillAmount();
    }

    private void TweenImageFillAmount()
    {
        DOTween.To(delegate (float value)
        {

            mImage.fillAmount = value;

        }, mOldAmount, mNewAmount, 2f);
    }
}
