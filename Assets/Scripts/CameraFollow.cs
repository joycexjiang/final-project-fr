using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] public Transform player;

    private void Update()
    {

        transform.position = new UnityEngine.Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
