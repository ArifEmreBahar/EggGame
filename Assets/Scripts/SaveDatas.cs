using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDatas : MonoBehaviour
{
    public Vector3 playerSpawnPoint;

    public void GetSavedData()
    {
        playerSpawnPoint.x = PlayerPrefs.GetFloat("LastPositionX");
        playerSpawnPoint.y = PlayerPrefs.GetFloat("LastPositionY");
        playerSpawnPoint.z = PlayerPrefs.GetFloat("LastPositionZ");
    }

    public void Save()
    {
        playerSpawnPoint = GameObject.Find("White").GetComponent<SpawnPlayer>().lastPosition;
        PlayerPrefs.SetFloat("LastPositionX", playerSpawnPoint.x);
        PlayerPrefs.SetFloat("LastPositionY", playerSpawnPoint.y);
        PlayerPrefs.SetFloat("LastPositionZ", playerSpawnPoint.z);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            playerSpawnPoint = new Vector3(-2f,68.3f,0f);
            PlayerPrefs.SetFloat("LastPositionX", playerSpawnPoint.x);
            PlayerPrefs.SetFloat("LastPositionY", playerSpawnPoint.y);
            PlayerPrefs.SetFloat("LastPositionZ", playerSpawnPoint.z);

        }
    }
}
