using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public Image mImage;
    private int mOldAmount = 0;
    private int mNewAmount = 1;
    public Image spere;
    public Image spereTwo;

    private void Start()
    {
        spere.gameObject.transform.DOMove(spereTwo.transform.position, 6f);
    }

    private void OnEnable()
    {
        TweenImageFillAmount();
    }

    public void TweenImageFillAmount()
    {
        DOTween.To(delegate (float value)
        {

            mImage.fillAmount = value;
            if (mImage.fillAmount == 1)
            {
                spere.color = new Color(0, 0, 0, 0);
                SceneManager.LoadScene(0);
                
            }

        }, mOldAmount, mNewAmount, 6f);
    }
}
