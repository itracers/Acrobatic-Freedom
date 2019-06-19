using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMovement : MonoBehaviour
{
    public float speed = 2f;
    public Text UIText;

    public Transform startTransformToCamera;

    void FixedUpdate() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        UIText.text = $"Horizontal:{horizontalAxis} \n" +
                      $"Vertical:{verticalAxis} \n\n" +
                      $"X:{gameObject.transform.position.x}\n" +
                      $"Y:{gameObject.transform.position.y}\n" +
                      $"Z:{gameObject.transform.position.z}\n" +
                      $"MousePosition:{new Vector3(Input.mousePosition.x, 0f, Input.mousePosition.z)}\n";

        gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + verticalAxis * speed);
        gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x + horizontalAxis * speed, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    /*  void Update() {
        RaycastHit hit;
        Debug.DrawRay(startTransformToCamera.position, Input.mousePosition, Color.red);
        Ray ray = new Ray(startTransformToCamera.position, new Vector3(Input.mousePosition.x, 0f, Input.mousePosition.z));
    }   */
}