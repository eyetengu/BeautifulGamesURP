using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinLookX : MonoBehaviour
{
    [SerializeField]
    private float _sensitivity = 1f;

    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += _mouseX * _sensitivity;
        transform.localEulerAngles = newRotation;

    }
}
