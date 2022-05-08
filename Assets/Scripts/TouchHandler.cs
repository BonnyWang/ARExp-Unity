using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject touchPrefab;
    public Camera camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            // Update the Text on the screen depending on current position of the touch each frame
            // Debug.Log(touch.position);

            Vector3 objPosition = touch.position;
            objPosition.z = 0.25f;

            Vector3 instanPosi  = camera.ScreenToWorldPoint(objPosition);

            GameObject temp =  Instantiate(touchPrefab, instanPosi, Quaternion.identity);

            Debug.Log(temp);
        }
    }
}
