using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    [Header("���������������� ����")]
    public float sensitivity = 200f;
    public Transform Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX = Input.GetAxis("mouseX") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("mouseY") * sensitivity * Time.deltaTime;

        Player.Rotate(mouseX * new Vector3(0, 1, 0));
        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}
