using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmiter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;


    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidBodyValues());
    }
}
