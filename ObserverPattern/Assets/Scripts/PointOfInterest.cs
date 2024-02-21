using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : MonoBehaviour
{
    public static event Action<PointOfInterest> OnPointOfInterestEntered;

    [SerializeField] private string _poiName;

    public string PoiName => _poiName;
    private void OnTriggerEnter(Collider other)
    {
        if (OnPointOfInterestEntered != null)
            OnPointOfInterestEntered(this);
    }
}
