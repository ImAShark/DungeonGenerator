using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    [SerializeField] private GameObject[] RoomsT;
    [SerializeField] private GameObject[] RoomsB;
    [SerializeField] private GameObject[] RoomsL;
    [SerializeField] private GameObject[] RoomsR;
    private GameObject room;
    [SerializeField] private int DungeonLength;

    public int GetDungeonLenght()
    {
        return DungeonLength;
    }
    
    public GameObject requestRoom(int dir)
    {
        
        switch (dir)
        {   
            case 0:
                GameObject room = RoomsT[randomInt()];
                break;
            case 1:
                GameObject roomB = RoomsT[randomInt()];
                break;
            case 2:
                GameObject roomL = RoomsT[randomInt()];
                break;
            case 3:
                GameObject roomR = RoomsT[randomInt()];
                break;
            default:
                break;
        }
        
        return room;
    }

    private int randomInt()
    {
        int i = Mathf.RoundToInt(Mathf.Floor(Random.Range(0f,6f)));
        return i;
    }
}
