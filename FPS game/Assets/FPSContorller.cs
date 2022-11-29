using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSContorller : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera Info")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    
    private float rotX;
    private Camera camera;
    private Rigidbody rb;

    void Awake()
    {
        
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
      PlayerMove();
      CameraLook();

      if(Input.GetButtonDown("Jump"))
        PlayerJump();   
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;    
        
        rb.velocity = dir;
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void PlayerJump()
    {
        
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
