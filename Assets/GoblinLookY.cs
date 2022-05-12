using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinLookY : MonoBehaviour
{
    private float _sensitivity = -1.0f;
    private Vector3 _vector3;

    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x += _mouseY * _sensitivity;
        transform.localEulerAngles = newRotation;
    }
}
