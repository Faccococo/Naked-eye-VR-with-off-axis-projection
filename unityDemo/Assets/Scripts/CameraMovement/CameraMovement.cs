using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    private CameraMouseLook mouseLook;
    private GameController gameController = GameController.getInstance();

    private void Start()
    {
        moveSpeed *= 60;
        mouseLook = GetComponent<CameraMouseLook>();
    }

    private void Update()
    {
        var input_ws = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        var input_ad = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        var input_space = Input.GetKey(KeyCode.Space) ? 1 : 0;
        var input_shift = Input.GetKey(KeyCode.LeftShift) ? -1 : 0;
        var input_up_down = (input_space + input_shift) * 0.1f * moveSpeed * Time.deltaTime;


        var crossMoveDirection = Vector3.Cross(Vector3.up, transform.forward).normalized;
        
        Vector3 move_direction = input_ws * transform.forward.normalized + input_up_down * transform.up.normalized + input_ad * crossMoveDirection;

        //transform.LookAt(objectLookAt.transform);
        transform.position += move_direction;
        //gameController.logInfo();
    }
}
