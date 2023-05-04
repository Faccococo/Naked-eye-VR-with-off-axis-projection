using UnityEngine;
using System.Collections;

public class CameraMouseLook : MonoBehaviour
{

	public float rotateSpeed;

	// Use this for initialization
	void Start()
	{
		rotateSpeed = rotateSpeed * 60;

		//隐藏鼠标指针
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
	{
		float input_x = Input.GetAxis("Mouse X");
        float input_y = -Input.GetAxis("Mouse Y");

        Quaternion rotation = Quaternion.Euler(input_y * Time.deltaTime * rotateSpeed, 0, 0);

        transform.localRotation *= rotation;

        rotation = Quaternion.Euler(0, input_x * Time.deltaTime * rotateSpeed, 0);

        transform.localRotation = rotation * transform.localRotation;

    }
}

