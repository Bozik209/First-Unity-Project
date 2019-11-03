using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerCube;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerCube.position + offset;
    }
}
