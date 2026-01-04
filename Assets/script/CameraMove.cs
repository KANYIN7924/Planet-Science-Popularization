using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface MouseEventByTagBase { public void EventByTag(GameObject obj); }
public class CameraMove : MonoBehaviour
{
    private Transform planet;
    public Transform planetOne;
    public Transform[] planetZ;
    public Text[] TextZ;

    public GameObject guideText;

    
    public float Xzhou = 0f, Yzhou = 0f, Zzhou = 0f;
    public bool Xflag = false, Yflag = false;

   
    public float Xspeed = 140, Yspeed = 100, Mspeed = 5;

   

    public float Yminlimit = -50, Ymaxlimit = 80;
    public float Xleftmax = -365, Xrightmax = 365;
    public float distence = 5, Mindistence = 6, Maxdistence = 15;

    
    public bool NeedDamping = true; public float damping = 5;

    public void SetTarget(Transform transform)
    {
        planet = transform;
    }

    void Start()
    {
        
        SetTarget(planetOne);
        Vector3 angle = transform.eulerAngles;
        Xzhou = angle.y; Yzhou = angle.x;

    }
    Ray Ray;
    RaycastHit Hit;
    GameObject objct;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Camera.main != null) Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Ray, out Hit))
            {
                objct = Hit.collider.gameObject;

                if (objct.CompareTag("Planet"))
                {
                    print("object?"+objct);

                    if (objct.name.Equals("sun"))
                    {
                        guideText.SetActive(true);
                        SetTarget(planetZ[0]);
                        distence = 2500f;
                        Mindistence = 2500f;
                        
                        TextZ[0].gameObject.SetActive(true);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    else { distence = 50f;Mindistence = 55f;guideText.SetActive(false); }
                    if (objct.name.Equals("mercury"))
                    {
                        SetTarget(planetZ[1]);
                        TextZ[1].gameObject.SetActive(true);
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("venus"))
                    {
                        SetTarget(planetZ[2]);
                        distence = 150f;
                        TextZ[2].gameObject.SetActive(true);
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("spQ"))
                    {
                        SetTarget(planetZ[3]);
                        distence = 150f;
                        TextZ[3].gameObject.SetActive(true);
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("mars"))
                    {
                        SetTarget(planetZ[4]);
                        distence = 150f;
                        TextZ[4].gameObject.SetActive(true);
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("jupiter"))
                    {
                        SetTarget(planetZ[5]);
                        distence = 150f;
                        TextZ[5].gameObject.SetActive(true);
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("saturn"))
                    {
                        SetTarget(planetZ[6]);
                        distence = 150f;
                        TextZ[6].gameObject.SetActive(true);
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("uranus"))
                    {
                        SetTarget(planetZ[7]);
                        distence = 150f;
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(true);
                        TextZ[8].gameObject.SetActive(false);
                    }
                    if (objct.name.Equals("neptune"))
                    {
                        SetTarget(planetZ[8]);
                        distence = 150f;
                        TextZ[0].gameObject.SetActive(false);
                        TextZ[1].gameObject.SetActive(false);
                        TextZ[2].gameObject.SetActive(false);
                        TextZ[3].gameObject.SetActive(false);
                        TextZ[4].gameObject.SetActive(false);
                        TextZ[5].gameObject.SetActive(false);
                        TextZ[6].gameObject.SetActive(false);
                        TextZ[7].gameObject.SetActive(false);
                        TextZ[8].gameObject.SetActive(true);
                    }
                }
                else { var _event = objct.GetComponent<MouseEventByTagBase>(); _event?.EventByTag(objct); }
            }

        }
    }
    void LateUpdate()
    {
        if (planet)
        {
            if (Input.GetMouseButton(0))
            {
                if (Yzhou > 95 && Yzhou < 270 || (Yzhou < -95 && Yzhou > -270))
                {
                    Xzhou -= Input.GetAxis("Mouse X") * Xspeed * 0.02f;

                }
                else
                {
                    Xzhou += Input.GetAxis("Mouse X") * Xspeed * 0.02f;
                }

                Yzhou -= Input.GetAxis("Mouse Y") * Yspeed * 0.02f;
                Xzhou = ClampAngle(Xzhou, Xleftmax, Xrightmax);
                Yzhou = ClampAngle(Yzhou, Yminlimit, Ymaxlimit);

            }
            distence -= Input.GetAxis("Mouse ScrollWheel") * Mspeed;
            distence = Mathf.Clamp(distence, Mindistence, Maxdistence);


            Quaternion rotion = Quaternion.Euler(Yzhou, Xzhou, Zzhou);

            Vector3 disvector3 = new Vector3(0.0f, 0.0f, -distence);
                                                                   
            Vector3 position = rotion * disvector3 + planet.position;

            if (NeedDamping)
            {

                transform.rotation = Quaternion.Lerp(transform.rotation, rotion, Time.deltaTime * damping);
                                                                                                           
                transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * damping);
            }
            else { transform.rotation = rotion; transform.position = position; }
        }
    }
    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
