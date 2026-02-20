using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private Transform theCamera;
    [SerializeField] private Vector3 previousPosition; //value type
    // Start is called before the first frame update
    void Start()
    {
        // hell part2 let's go
        //bazinga
        //jdhwajhbwds
        //tyler the creator is cool
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
