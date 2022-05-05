using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageTrackAction : MonoBehaviour
{
    public ARTrackedImageManager manager;
    public GameObject textPrefab;
    public GameObject Text;
    void Start()
    {
        // manager = GetComponent<ARTrackedImageManager>();
        Text.GetComponent<UnityEngine.UI.Text>().text = "??????????????";
    }

    void OnEnable() => manager.trackedImagesChanged += OnChanged;

    void OnDisable() => manager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            Debug.Log(newImage.referenceImage.name);

            // manager.trackedImagePrefab.GetComponent<UnityEngine.UI.Text>().text = newImage.name;
            
            
            // Vector3 imagePosition = newImage.gameObject.transform.posi;
            // Quaternion imageRotation =  newImage.gameObject.transform.rotation;
            GameObject imageText = Instantiate(textPrefab, new Vector3(0,0,0),Quaternion.identity);
            imageText.GetComponent<TextMesh>().text = newImage.referenceImage.name;
            imageText.transform.parent = newImage.transform;
            // newImage.GetComponent<TextMesh>().text = newImage.referenceImage.name;
            Text.GetComponent<UnityEngine.UI.Text>().text = newImage.referenceImage.name;


        }

        foreach (var updatedImage in eventArgs.updated)
        {
        }

        foreach (var removedImage in eventArgs.removed)
        {
            // Handle removed event
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
