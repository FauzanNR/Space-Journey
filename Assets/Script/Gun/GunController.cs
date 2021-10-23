using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour{
    int bulletcount = 0;
    public Rigidbody bullet;
    float time = 3;
    public float SpeedBulet = 10f;
    void Update(){
        Rigidbody instant = null;
        
        if(Input.GetButtonDown("Fire1")){
            bulletcount += 1;
            print("Bullet "+bulletcount);
            time += Time.deltaTime;
            instant = Instantiate(bullet, 
                                    transform.position, 
                                    transform.rotation)as Rigidbody;
            instant.velocity = transform.TransformDirection(new Vector3(0,0,5)*SpeedBulet);            
        }
    }
   
}
