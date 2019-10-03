using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] float offsetX, offsetZ;
    [SerializeField] int width, heigth;
    GameObject controller, hall;

    void Start()
    {
        controller = GameObject.Find("GenController");
        for (int x = 0; x < width; x++)
        {

            for (int z = 0; z < heigth; z++)
            {
                if (z % 2 == 0)
                {
                    hall = GetComponent<GeneratorController>().RequestRoom(Random.Range(0,4));
                    Debug.Log(hall.gameObject);
                    Instantiate(hall, new Vector3(x * offsetX, 0, z * offsetZ), Quaternion.identity);
                }

            }
            
        }
    }

}
