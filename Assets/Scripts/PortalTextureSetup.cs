using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    [SerializeField] Camera cameraGrey;

    [SerializeField] Material cameraMatGrey;

    //[SerializeField] Camera cameraA;

    //[SerializeField] Material cameraMatA;

    [SerializeField] Camera[] goodCameras;
    [SerializeField] Material[] goodCameraMats;

    [SerializeField] Camera[] badCameras;
    [SerializeField] Material[] badCameraMats;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < goodCameras.Length; i ++)
        {
            if (goodCameras[i].targetTexture != null)
            {
                goodCameras[i].targetTexture.Release();
            }
            goodCameras[i].targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            goodCameraMats[i].mainTexture = goodCameras[i].targetTexture;
        }

        //if (cameraA.targetTexture != null)
        //{
        //    cameraA.targetTexture.Release();
        //}
        //cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        //cameraMatA.mainTexture = cameraA.targetTexture;

        //if (cameraB.targetTexture != null)
        //{
        //    cameraB.targetTexture.Release();
        //}
        //cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        //cameraMatB.mainTexture = cameraB.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
