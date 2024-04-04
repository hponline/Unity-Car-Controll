using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // hiz ve yon degiskenleri
    [SerializeField]
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputId;
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputId);
        forwardInput = Input.GetAxis("Vertical" + inputId);

        // Arac hareket ileri hareketi
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);




        // Arac yon hareketi
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
