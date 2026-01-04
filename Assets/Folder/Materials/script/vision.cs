using System.Collections;
using System.Collections.Generic;
using Unity.XR.PXR;
using UnityEngine;

public class vision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 开启透视
        PXR_Manager.EnableVideoSeeThrough = true;

        // 关闭透视
        //PXR_Manager.EnableVideoSeeThrough = false;

        PXR_Manager.VstDisplayStatusChanged += VstDisplayStatusChanged;
    }

private void VstDisplayStatusChanged(PxrVstStatus status)
    {
        switch (status)
        {
            case PxrVstStatus.Disabled: // 已关闭
                break;
            case PxrVstStatus.Enabling: // 开启中
                break;
            case PxrVstStatus.Enabled: // 已开启
                break;
            case PxrVstStatus.Disabling: // 关闭中
                break;
        }
    }

}


// Update is called once per frame
