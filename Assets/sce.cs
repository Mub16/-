using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        var bounds = gameObject.GetComponent<MeshFilter>();
        var sizeX  = bounds.transform.localScale.x;
        var sizeY  = bounds.transform.localScale.y;
        var sizeZ = bounds.transform.localScale.z;
        print(sizeX);
        print(sizeY);
        print(sizeZ);
        gameObject.AddComponent<BoxCollider>().size = new Vector3(sizeX, sizeY, sizeZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
