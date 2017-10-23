using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Switcher : MonoBehaviour {
    public Cam_Locker lockcam;
    //int declarations
    public int lockcamreciever;
    public int WhichCam;
    // cam declarations
    public Camera MainCam;
    public Camera Cam1;
    public GameObject CameraParent;
    //light declaration
    public Light Cam10light;
    // blocker declaration
    public MeshRenderer cam10blocker;
    public MeshRenderer cam9blocker;
    //text declaration
    public Text text;
    //spriterenderer declaration
    public SpriteRenderer WHL;
    public SpriteRenderer WHH;
    public SpriteRenderer EHL;
    public SpriteRenderer EHH;
    public SpriteRenderer Kitchen;
    public SpriteRenderer Toilets;
    public SpriteRenderer Show_Stage;
    public SpriteRenderer Diner;
    public SpriteRenderer PirateCove;
    public SpriteRenderer Services;
    public SpriteRenderer MangleCove;

    // Use this for initialization
    void Start () {
        WhichCam = 1;
	}
	
	// Update is called once per frame
	void Update () {
        lockcamreciever = lockcam.C_Lock;
        //Links
        MainCamera();
        WestHallLower();
        EastHallLower();
        WestHallHigher();
        EastHallHigher();
        //increase cam 
        if (Input.GetKeyDown(KeyCode.LeftArrow) && 10 > WhichCam)
        {
            WhichCam++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && WhichCam > 0)
        {
            WhichCam--;
        }
        if (Input.GetKeyDown(KeyCode.Space) && lockcamreciever == 1)
        {
            lockcamreciever = 0;
        }

    }
    void MainCamera()
    {
        if (lockcamreciever == 0)
        {
            MainCam.enabled = true;
            //West Hall Lower
            Cam1.enabled = false;
            cam10blocker.enabled = false;
            Cam10light.enabled = false;
        }
    }
    void WestHallLower()
    {
        if (WhichCam == 1 && lockcamreciever == 1)
        {
            CameraParent.transform.position = new Vector4(11.5f, 54.9f, 15.3f);
            // CameraParent.transform.rotation = new Quaternion(0.0f, 88.56f ,0.0f, 0.0f);
            MainCam.enabled = false;
            Cam1.enabled = true;
            cam10blocker.enabled = true;
            cam9blocker.enabled = false;
            Cam10light.enabled = true;
            text.text = "West Hall [Lower]";
            //lookup visibility
            WHL.enabled = true;
            WHH.enabled = false;
            EHL.enabled = false;
            EHH.enabled = false;
            Kitchen.enabled = false;
            Toilets.enabled = false;
            Show_Stage.enabled = false;
            Diner.enabled = false;
            PirateCove.enabled = false;
            Services.enabled = false;
            MangleCove.enabled = false;
        }
    }
    void EastHallLower()
    {
        if (WhichCam == 2 && lockcamreciever == 1)
        {
            CameraParent.transform.position = new Vector4(11.5f, 54.9f, -10.8f);
            // CameraParent.transform.rotation = new Quaternion(0.0f, 88.56f, 0.0f, 0.0f);
            MainCam.enabled = false;
            Cam1.enabled = true;
            cam10blocker.enabled = false;
            cam9blocker.enabled = true;
            Cam10light.enabled = true;
            text.text = "East Hall [Lower]";
            //lookup visibility
            WHL.enabled = false;
            WHH.enabled = false;
            EHL.enabled = true;
            EHH.enabled = false;
            Kitchen.enabled = false;
            Toilets.enabled = false;
            Show_Stage.enabled = false;
            Diner.enabled = false;
            PirateCove.enabled = false;
            Services.enabled = false;
            MangleCove.enabled = false;
        }
    }
    void WestHallHigher()
    {
        if (WhichCam == 3 && lockcamreciever == 1)
        {
            CameraParent.transform.position = new Vector4(51.3f, 54.9f, 15.21f);
            // CameraParent.transform.rotation = new Quaternion(0.0f, 88.56f, 0.0f, 0.0f);
            MainCam.enabled = false;
            Cam1.enabled = true;
            cam10blocker.enabled = false;
            cam9blocker.enabled = false;
            Cam10light.enabled = true;
            text.text = "West Hall [Higher]";
            //lookup visibility
            WHL.enabled = false;
            WHH.enabled = true;
            EHL.enabled = false;
            EHH.enabled = false;
            Kitchen.enabled = false;
            Toilets.enabled = false;
            Show_Stage.enabled = false;
            Diner.enabled = false;
            PirateCove.enabled = false;
            Services.enabled = false;
            MangleCove.enabled = false;
        }
    }
    void EastHallHigher()
    {
        if (WhichCam == 4 && lockcamreciever == 1)
        {
            CameraParent.transform.position = new Vector4(51.3f, 54.9f, -15.21f);
            // CameraParent.transform.rotation = new Quaternion(0.0f, 88.56f, 0.0f, 0.0f);
            MainCam.enabled = false;
            Cam1.enabled = true;
            cam10blocker.enabled = false;
            cam9blocker.enabled = false;
            Cam10light.enabled = true;
            text.text = "East Hall [Higher]";
            //lookup visibility
            WHL.enabled = false;
            WHH.enabled = false;
            EHL.enabled = false;
            EHH.enabled = true;
            Kitchen.enabled = false;
            Toilets.enabled = false;
            Show_Stage.enabled = false;
            Diner.enabled = false;
            PirateCove.enabled = false;
            Services.enabled = false;
            MangleCove.enabled = false;
        }
    }
}
