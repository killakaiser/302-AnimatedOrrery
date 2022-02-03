using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownCameraMenu : MonoBehaviour
{
    public Camera FlyByCamera;
    public Camera VenusCamera;
    public Camera MarsCamera;
    public Camera EarthCamera;
    public Camera JupiterCamera;
    public Camera NeptuneCamera;

    public void Start()
    {

    }

    // Call this function to disable the selected planet's camera,
    // and enable the FlyBy camera.
    public void ShowFlyByCamera()
    {
        FlyByCamera.enabled = true;
        VenusCamera.enabled = false;
        MarsCamera.enabled = false;
        EarthCamera.enabled = false;
        JupiterCamera.enabled = false;
        NeptuneCamera.enabled = false;

    }
    // Call this function to disable the FlyBy camera,
    // and enable each planet's camera, respectively.
    public void ShowVenusCamera()
    {
        FlyByCamera.enabled = false;
        VenusCamera.enabled = true;
        MarsCamera.enabled = false;
        EarthCamera.enabled = false;
        JupiterCamera.enabled = false;
        NeptuneCamera.enabled = false;
    }

    public void ShowMarsCamera()
    {
        FlyByCamera.enabled = false;
        VenusCamera.enabled = false;
        MarsCamera.enabled = true;
        EarthCamera.enabled = false;
        JupiterCamera.enabled = false;
        NeptuneCamera.enabled = false;

    }

    public void ShowEarthCamera()
    {
        FlyByCamera.enabled = false;
        VenusCamera.enabled = false;
        MarsCamera.enabled = false;
        EarthCamera.enabled = true;
        JupiterCamera.enabled = false;
        NeptuneCamera.enabled = false;

    }
    public void ShowJupiterCamera()
    {
        FlyByCamera.enabled = false;
        VenusCamera.enabled = false;
        MarsCamera.enabled = false;
        EarthCamera.enabled = false;
        JupiterCamera.enabled = true;
        NeptuneCamera.enabled = false;

    }
    public void ShowNeptuneCamera()
    {
        FlyByCamera.enabled = false;
        VenusCamera.enabled = false;
        MarsCamera.enabled = false;
        EarthCamera.enabled = false;
        JupiterCamera.enabled = false;
        NeptuneCamera.enabled = true;

    }
}
