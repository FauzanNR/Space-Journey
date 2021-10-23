using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerGravity : MonoBehaviour{

    PlanetGravitasi planetGravitasi;
    private void Awake() {
        planetGravitasi = GameObject.FindGameObjectWithTag("Globe").GetComponent<PlanetGravitasi>();
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        planetGravitasi.Gravitasi(transform);
    }
}
