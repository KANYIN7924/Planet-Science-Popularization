using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.PXR;
using Unity.XR.PICO.TOBSupport;
using UnityEngine.UI;
using TMPro;
using System;
using Pico.Platform;
using Pico.Platform.Models;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class TestID : MonoBehaviour
{
    public TextMeshProUGUI text_UI;
    public InputActionProperty key; //


    [Header("大空间配置")]
    public bool autoInitialize = true;
    public bool enableLargeSpace = true;
    public string largeSpaceSceneId = "default_large_space";

    [Header("调试设置")]
    public bool enableDebugLog = true;
    public bool showTrackingVisualization = true;

    // 大空间状态
    private bool isInitialized = false;


    [SerializeField] private int targetID = 200;
    [SerializeField] private int location = 201;

    void Start()
    {
        PXR_Manager.EnableVideoSeeThrough = true;
        key.action.Enable();
        key.action.performed += (c) =>
        {
            Test("按下扳机");

            PXR_Enterprise.SwitchLargeSpaceScene(true, (b) =>
            {
                Test("大空间状态：" + b);
                //PXR_Enterprise.SaveLargeSpaceMaps();
                PXR_Enterprise.SetMarkerInfoCallback(UnityEngine.XR.TrackingOriginModeFlags.Floor, 1.36f, (info) => Scene(info[0].iMarkerId));
            });
        };
        if (text_UI != null)
        {
            text_UI.text = "kkkkkkkkkkkkkk";
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI组件未赋值！");

        }
        //bool isEnable = false;
        PXR_Enterprise.InitEnterpriseService();
        PXR_Enterprise.BindEnterpriseService((result) =>
        {
            if (result)
            {
                Test("空间定位扫描启动");
            }
        });

    }
    private void Scene(int id)
    {
        switch (id)
        {
            case 200:
                Test("识别到ID：200");
                SceneManager.LoadScene("Observe");
                break;
            case 201:
                Test("识别到ID：201");
                SceneManager.LoadScene("ID 201");
                break;
            default:
                break;
        }
    }
    private void Test(string id)
    {
        if (text_UI != null)
        {
            if (!string.IsNullOrEmpty(id) && id != "null")
                text_UI.text = id;
            else text_UI.text = "未识别到id";
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI组件未赋值！");

        }
    }


}




