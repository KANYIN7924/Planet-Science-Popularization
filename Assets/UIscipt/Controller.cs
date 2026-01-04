using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI text_ui;

    public  void OnAdd()
    {
        var str_text=text_ui.text;
        int new_num=int.Parse(str_text)+1;
        text_ui.text=new_num.ToString();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
