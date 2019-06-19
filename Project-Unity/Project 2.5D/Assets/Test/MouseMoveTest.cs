using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveTest : MonoBehaviour
{
    public GameObject go;
    public float sensitivity = 1F;
    private Camera goCamera;
    private Vector3 MousePos;
    private float MyAngle = 0F;

    void Start()
    {
        // Инициализируем кординаты мышки и ищем главную камеру
        goCamera = Camera.main;
        go = goCamera.transform.parent.gameObject;
    }

    void Update()
    {
        MousePos = Input.mousePosition;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            MyAngle = 0;

            MyAngle = sensitivity * ((MousePos.x - (Screen.width / 2)) / Screen.width);
            goCamera.transform.RotateAround(go.transform.position, goCamera.transform.up, MyAngle);
            MyAngle = sensitivity * ((MousePos.y - (Screen.height / 2)) / Screen.height);
            goCamera.transform.RotateAround(go.transform.position, goCamera.transform.right, -MyAngle);
        }
    }
}
