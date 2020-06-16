using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCreator : MonoBehaviour
{

    [SerializeField,Tooltip("瓷砖地形预制体")] private GameObject TerrainTile = null;
    public int terrainCount = 10;


    [SerializeField,Tooltip("障碍物地形列表")] GameObject[] barriers;



    private void Awake()
    {
        if (!TerrainTile) return;
        for (int i = 0; i < terrainCount; i++)
        {
            GameObject instance = Instantiate(TerrainTile);

           
            int index = Random.Range(0, barriers.Length );
            GameObject barInstance = Instantiate(barriers[index]);
            barInstance.transform.parent = instance.transform;
            barInstance.transform.position = new Vector3(0, 0, Random.Range(-1.0f, 1.0f));

            instance.transform.parent = transform;
            instance.transform.localPosition = new Vector3(i * 8, 0, 0);
        }
    }



}
