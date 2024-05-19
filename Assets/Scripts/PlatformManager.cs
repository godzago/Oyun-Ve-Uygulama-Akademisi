using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    private Vector3 lastEndPoint;

    [SerializeField] GameObject platfromPrefeb;

    [Header("Platform Count")]
    [SerializeField] int platfromsCount;
    public void Start()
    {
        SpawnPlatforms();
    }

    public void SpawnPlatforms()
    {
        for (int i = 0; i < platfromsCount; i++)
        {
            GameObject platfrom = GameObject.Instantiate(platfromPrefeb);
            Platform platfromScripts  = platfrom.GetComponent<Platform>();

            platfrom.transform.position = lastEndPoint;
            lastEndPoint = platfromScripts.ReturnEndPoint();
        }
    }
}
