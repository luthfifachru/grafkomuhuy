using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public Transform tile1Obj;
    private Vector3 nextTileSpawn;  

    void Start()
    {
     	nextTileSpawn.z = -84;
    	StartCoroutine(spawnTile());
    }

  
    void Update()
    {

    }
    	IEnumerator spawnTile()
    	{
    		yield return new WaitForSeconds(1);
    		Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
    		nextTileSpawn.z += -7;
    		Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
    		nextTileSpawn.z += -7;
    		StartCoroutine(spawnTile());
    	}
}

