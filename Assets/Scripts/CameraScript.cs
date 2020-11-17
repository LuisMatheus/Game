using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float rotate_speed = 0.1f;

    void Update()
    {

    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.up,90,Space.Self);
    }

    public void RotateRight()
    {
        transform.Rotate(Vector3.up, -90, Space.Self);
    }
}
