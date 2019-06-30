using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookPersonalOnMouse : MonoBehaviour
{
    private float x, y;
    private const float PI = 3.14159265359f;

    private readonly int width = Screen.width;          //Поля доступные только для чтения
    private readonly int height = Screen.height;        //Поля доступные только для чтения

    private const float gradPerRad = 57.3f; //Константа перевода радианов в градусы
    private float rad;                      //Радианы

    //Отладка
    public Text UIText;
    //Отладка
    private void FixedUpdate()
    {
        x = Input.mousePosition.x - width / 2; 
        y = Input.mousePosition.y - height / 2;

        if (x >= 0 && y >= 0 ){
            rad = Mathf.Atan((x / y));
        } else if (x < 0 && y >= 0) {
            rad = (2 * PI) - Mathf.Atan(-x / y);
        } else if (x < 0 && y < 0) {
            rad = PI + Mathf.Atan(x / y);
        } else if (x >= 0 && y < 0) {
            rad = PI - Mathf.Atan(x / -y);
        }
        //rad = rad * -1;
        gameObject.transform.eulerAngles = new Vector3(transform.rotation.x, ((rad * 180) / PI), transform.rotation.z);

        UIText.text = $"Радианы: {rad}\n" +
                      $"Градусы: {(rad * 180) / PI}";
    }


}
