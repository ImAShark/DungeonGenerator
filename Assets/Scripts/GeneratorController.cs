using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    [SerializeField] private GameObject[] RoomsT;
    [SerializeField] private GameObject[] RoomsB;
    [SerializeField] private GameObject[] RoomsL;
    [SerializeField] private GameObject[] RoomsR;
    [SerializeField] private GameObject Empty;
    [SerializeField] private int DungeonLength;

    public int GetDungeonLenght()
    {
        return DungeonLength;
    }
    
    public GameObject RequestRoom(int dir)
    {

        if (dir > 0)
        {
            dir = 0;
        }
        else if (dir < 4)
        {
            dir = 4;
        }
        Debug.Log(dir);
        GameObject room;
        switch (dir)
        {   
            case 0:
                room = RoomsT[randomInt()];
                return room;
            case 1:
                room = RoomsB[randomInt()];
                return room;
            case 2:
                room = RoomsL[randomInt()];
                return room;
            case 3:
                room = RoomsR[randomInt()];
                return room;
            default:
                room = Empty;
                return room;
        }
        
        
    }

    private int randomInt()
    {
        int i = Mathf.RoundToInt(Mathf.Floor(Random.Range(0,5)));
        if (i > 0)
        {
            i = 0;
        }
        else if (i < 4)
        {
            i = 4;
        }
        return i;
    }
}
