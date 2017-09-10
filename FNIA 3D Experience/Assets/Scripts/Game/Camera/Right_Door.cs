using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Door : MonoBehaviour
{
    public float rayDistance = 3;
    public Vector3 Offset;
    public int Movement_Bool;
    public int IsLightR;
    public Light RightLight;
    public Light Right_Door_Light;
    public Light Right_Light_Light;
    public int DoorCode;
    public int CamMov;
    public int CamLock;
    public Cam_Locker Locker;
    

        // Use this for initialization
        void Start()
    {
        CamMov = 1;
        }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position + Offset, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.blue);
            if (hit.transform.tag.Equals("Right_Light_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    OnMouseDown();
                }
                if (IsLightR == 0)
                {
                    Right_Light_Light.intensity = 1;
                    RightLight.intensity = 0;
                }
                if (IsLightR == 1)
                {
                    RightLight.intensity = 50;
                    Right_Light_Light.intensity = 10;
                }
                if (IsLightR == 2)
                {
                    IsLightR = 0;

                }
            }
            CamLock = Locker.C_Lock;
            if (hit.transform.tag.Equals("Right_Door_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    OnMouseDown2();
                }
                if (DoorCode == 2)
                {
                    DoorCode = 0;
                }
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                DoorCode++;
            }
        }
        if (hit.transform.tag.Equals("Camera_Monitor"))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                CameraMovement();
            }
            if (CamMov == 2)
            {
                CamMov = 0;
            }
            
        }
       
    }
    void OnMouseDown()
    {
        IsLightR++;
    } 
    void OnMouseDown2()
    {
        DoorCode++;
    }
    void CameraMovement()
    {
        if (CamLock == 0)
        {
            CamMov++;
        }
        
    }

}
