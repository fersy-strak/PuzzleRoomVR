using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenuLogic : MonoBehaviour
{
    public GameObject ControlStation; //menuPad
    protected bool isVisible = true;

    public GameObject LocationTarget;
    public GameObject LocationDirection;
    public float LocationOffset;

    public void ShowAndHide()
    {
        //SetLocation();

        ControlStation.SetActive(!isVisible);


        if (isVisible)
        {
            //MenuPad.hide();
        }
        else
        {
            //MenuPad.show();
        }

        isVisible = !isVisible;
    }

    public void SetLocation()
    {
        if (LocationTarget == null || LocationDirection == null)
        {
            return;
        }

        Vector3 locationDirectionPosition = LocationDirection.transform.position;
        Vector3 locationTargetPosition = LocationTarget.transform.position;

        transform.position = new Vector3(locationDirectionPosition.x, locationTargetPosition.y, locationDirectionPosition.z);
        ControlStation.transform.localPosition = LocationDirection.transform.forward * LocationOffset;

        Vector3.Scale(ControlStation.transform.localPosition, Vector3.right + Vector3.forward);
        Vector3 targetPosition = locationDirectionPosition;
        targetPosition.y = locationTargetPosition.y;
        ControlStation.transform.LookAt(targetPosition);
        ControlStation.transform.localEulerAngles = Vector3.up * (ControlStation.transform.localEulerAngles.y + 180f);
    }
}
/*
using VRTK.Prefabs.Locomotion.Teleporters;
using Zinnia.Data.Type;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuLogic : MonoBehaviour
{
    public TeleporterFacade teleporter;
    public Transform playArea;
    public Transform headOrientation;
    public Transform pauseLocation;
    public Transform gameLocation;

    protected bool inPauseMenu = false;

    public List<GameObject> pauseItems;
    public List<GameObject> gameItems;

    public GameObject teleportationRelease;
    public GameObject teleportationPress;
    public void SwitchRooms()
    {
        TransformData teleportDestination = new TransformData(gameLocation);
        if (!inPauseMenu)
        {
            gameLocation.position = new Vector3(headOrientation.position.x, playArea.position.y, headOrientation.position.z);

            Vector3 right = Vector3.Cross(playArea.up, headOrientation.forward);
            Vector3 forward = Vector3.Cross(right, playArea.up);

            gameLocation.rotation = Quaternion.LookRotation(forward, playArea.up);

            teleportDestination = new TransformData(pauseLocation);
        }

        teleporter.Teleport(teleportDestination);
        inPauseMenu = !inPauseMenu;

        foreach (GameObject item in pauseItems)
        {
            item.SetActive(inPauseMenu);
        }

        foreach (GameObject item in gameItems)
        {
            item.SetActive(!inPauseMenu);
        }
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("Final", LoadSceneMode.Single);
    }

    public void SwitchTeleportationToPress(bool value)
    {
        teleportationRelease.SetActive(!value);
        teleportationPress.SetActive(value);
    }
    public void SwitchTeleportationToRelease(bool value)
    {
        SwitchTeleportationToPress(!value);
    }
}
*/
