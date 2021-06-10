using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public float parallaxRate = -3.0f;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        transform.position = new Vector3(cam.transform.position.x / parallaxRate, 0, 0);
    }
}
