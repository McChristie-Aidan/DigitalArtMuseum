using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraLocation : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] public float cameraHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + cameraHeight, this.gameObject.transform.position.z);
    }
}
