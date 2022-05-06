using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandle : MonoBehaviour
{
    // Use to get the current positoin of Player
    public GameObject Camera;
    public GameObject TextPrefab;
    public UnityEngine.UI.InputField inputField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateText(){
        Vector3 playerPosition = Camera.transform.position;
        Ray ray = Camera.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        Vector3 textPosition = playerPosition + ray.direction;
        GameObject tempText = Instantiate(TextPrefab, textPosition,Quaternion.identity);

        tempText.GetComponent<TextMesh>().text = inputField.text;

    }
}
