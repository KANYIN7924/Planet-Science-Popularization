//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TextGuide : MonoBehaviour
//{
//    public Transform target;
//    public float yOffset = 0;

//    void Update()
//    {
//        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
//        namePos.z = 0;
//        namePos.y += yOffset;
//        target.position = namePos;
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGuide : MonoBehaviour  // 修正类名
{
    public Transform target;
    public float yOffset = 0;

    void Update()
    {
        Debug.Log(Camera.main);
        // 添加空值检查，避免target未赋值时报错
        if (target != null)
        {
            //Vector3 screenPos = Camera.main.WorldToScreenPoint(this.transform.position);
            Vector3 screenPos = transform.position;

            screenPos.y += yOffset;  // 修正变量名
            target.position = screenPos;  // 修正变量名
        }
    }
}
