using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform pinkMan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // make camera follow player's x,y position
        transform.position = new Vector3(pinkMan.position.x, pinkMan.position.y, transform.position.z);
    }
}
