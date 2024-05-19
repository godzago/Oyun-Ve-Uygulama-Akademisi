using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    Transform player;

    [Header("Camera Settings")]
    [SerializeField] private Vector3 offset;

    private void Awake()
    {
       // player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
       // this.gameObject.transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, player.position.z + offset.z);
    }
}
