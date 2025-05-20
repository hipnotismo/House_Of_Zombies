using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [Header("Setup")]

    [SerializeField] private Transform PlayerBody;

    [SerializeField] private Transform CamHolder;
    [SerializeField] private Transform CamWeaponLayer;

    [Header("Movement")]

    [SerializeField] private float MouseSensitivity = 100f;

    private Vector2 MouseRot;

    private float XRotation;

   
    private void OnEnable()
    {
        InputManager.MoveCamera += CameraMovement;
    }

    private void OnDisable()
    {
        InputManager.MoveCamera -= CameraMovement;
    }
    private void Update()
    {
        var mouseX = MouseRot.x * MouseSensitivity * Time.deltaTime;
        var mouseY = MouseRot.y * MouseSensitivity * Time.deltaTime;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -70f, 70f);

        CamHolder.localRotation = Quaternion.Euler(XRotation, 0f, 0f);

        PlayerBody.Rotate(Vector3.up * mouseX);
    }


    public void CameraMovement(Vector2 inputValue)
    {
        MouseRot = inputValue;
    }
}
