using UnityEngine;
using System.Collections;

public class TouchHand : MonoBehaviour
{
    [SerializeField]
    private string normal = "normal";
    [SerializeField]
    private string touch = "touch";
    [SerializeField]
    private string touchTag = "Hair";

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == touchTag)
        {
//            Debug.Log("Found Hair:" + col.gameObject.name);
            SetFace(other.gameObject, touch);
        }
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == touchTag)
        {
//            Debug.Log("Exit Hair:" + col.gameObject.name);
            SetFace(other.gameObject, normal);
        }
    }

    private void SetFace(GameObject obj, string faceName)
    {
        GameObject rootGameObject = obj.transform.root.gameObject;
        MMD4MFaceController mmd4MFaceController;
        mmd4MFaceController = rootGameObject.GetComponent<MMD4MFaceController>();
        mmd4MFaceController.SetFace(faceName);
    }
}
