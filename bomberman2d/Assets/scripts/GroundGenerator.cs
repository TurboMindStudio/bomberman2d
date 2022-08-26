using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class GroundGenerator : MonoBehaviour
{
    [SerializeField] Tilemap grid;
    [SerializeField] Tile grassTile;
    [SerializeField] int xLenght;
    [SerializeField] int yLength;

    private void Start()
    {
        for (int x = 0; x < xLenght; x++)
        {
            for (int y = 0; y < yLength; y++)
            {
                grid.SetTile(new Vector3Int(x, y, 0), grassTile);
            }
        }
    }


}
