using UnityEngine;
using UnityEngine.SceneManagement;
// 根据使用的AR框架，可能需要引入额外的命名空间
// using Unity.MARS;
// using Unity.MARS.Data;

public class ImageTargetSceneLoader : MonoBehaviour
{
    [Tooltip("要跳转到的场景名称")]
    public string targetSceneName;

    [Tooltip("在场景跳转前等待的时间（秒）")]
    public float delayBeforeLoad = 0.5f;

    // 这个方法可以被MARS的MarkerCondition事件触发，或者由ARFoundation的图像跟踪事件触发
    public void OnMarkerRecognized()
    {
        Debug.Log("Marker Recognized! Preparing to load scene: " + targetSceneName);
        // 延迟一段时间后跳转，确保识别稳定
        Invoke("LoadTargetScene", delayBeforeLoad);
    }

    private void LoadTargetScene()
    {
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogError("Target scene name is not set!");
        }
    }
}