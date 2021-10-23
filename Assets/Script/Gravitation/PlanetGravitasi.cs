using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravitasi : MonoBehaviour{

private float gravitasi = -10;
    public void Gravitasi(Transform player){
        
        Vector3 target = (player.position - transform.position).normalized;
        Vector3 playerup = player.up;
        player.rotation = Quaternion.FromToRotation(playerup, target)*player.rotation;
        
        var magnitude = player.GetComponent<Rigidbody>().velocity.magnitude;
        if(magnitude > 20){
            gravitasi = 0;
            //print("ini gravitasi "+gravitasi);
            player.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,0));
            //player.GetComponent<Rigidbody>().AddForce(new Vector3(0,50,0), ForceMode.Acceleration);
            print("ini print player keluar atmospher "+magnitude);
    
        }else{
            gravitasi = -10;
            //print("ini magnitude "+magnitude);
        }
        player.GetComponent<Rigidbody>().AddForce(target*gravitasi, ForceMode.Acceleration);
    }
    
}
