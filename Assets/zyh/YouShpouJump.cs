using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class YouShpouJump : MonoBehaviour
{
    // Start is called before the first frame update

    public InputActionProperty key;
    public string sceneName;

    private void OnEnable()
    {
        key.action.Enable();
        key.action.performed += JunmpSaturn;
    }
    public void JunmpSaturn(InputAction.CallbackContext callback)
    {
      
        SceneManager.LoadScene(sceneName);
    
    }
   



}
