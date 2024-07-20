using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField][Range (0,3)] private float lerpValue;
    private Vector3 offSet;
    private Vector3 newPosition;
  
    void Start()
    {
        offSet = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCamerraSmoothFollow();
    }

    private void SetCamerraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position,ballTransform.position + offSet, lerpValue*Time.deltaTime);
        transform.position = newPosition;
    }
}
