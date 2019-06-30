using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPersonalOnMouse_2 : MonoBehaviour
{
    private readonly int width = Screen.width;          //Поля доступные только для чтения
    private readonly int height = Screen.height;        //Поля доступные только для чтения
    private void FixedUpdate() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



        Debug.DrawRay(Camera.main.transform.position, new Vector3(Input.mousePosition.x, -200f, Input.mousePosition.y), Color.red); //Отладка
    }
}
