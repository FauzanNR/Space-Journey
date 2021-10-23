using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class BulletGravity : MonoBehaviour{

    PlanetGravitasi planetGravitasi;
    private void Awake() {
        planetGravitasi = GameObject.FindGameObjectWithTag("Globe").GetComponent<PlanetGravitasi>();
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }

 void Update() {
         Destroy(gameObject, 3f);
}
    void FixedUpdate()
    {
        planetGravitasi.Gravitasi(transform);
    }
}
