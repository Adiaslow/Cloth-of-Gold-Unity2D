using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
 //Object References
 private TileManager _tileManager;

 // Variables
 [SerializeField] public int _width, _height;
 public GameObject[,] gridArray;

 private TileData _tile;

 void Start()
 {
    // GenerateGrid();
 }

 void Update()
 {
     for (int x = 0; x < _width; x++)
     {
         for (int y = 0; y < _height; y++)
         {
             var pos = new Vector2(x, y);
             var spawnedTile = GetTileAtPosition(pos);

             _tileManager.SetTiles(x, y, spawnedTile);
         }
     }
 }

 public void GenerateGrid()
 {
     // Dictionary<Vector2, TileData>();
     GameObject[,] gridArray = new GameObject; 

     for (int x = 0; x < _width; x++)
     {
         for (int y = 0; y < _height; y++)
         {
             var _tile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
             _tileManager.SetTiles()TileData.spawnedTile.name = $"Cell {x} {y}";

             _tileManager.SetTiles(x, y, spawnedTile);
             SetPlayerArea(x, _width, spawnedTile, playerAreaSizePercent);
             _tileManager.GetTiles()[new Vector2(x, y)] = spawnedTile;

            // return _tile;
         }
     }

     _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
 }

 public TileData GetTileAtPosition(Vector2 pos)
 {
     if(_tileManager.GetTiles().TryGetValue(pos, out var tile))
     {
         return tile;
     }

     return null;
 }

 public void SetPlayerArea(int x, int width, TileData spawnedTile, int playerAreaSizePercent)
 {
     var PlayerAreaType = 0;

     int tilesPerPlayer = width / (100 / playerAreaSizePercent);

     if (x >= 0 && x >= tilesPerPlayer) // FIXME
     {
         PlayerAreaType = 2;
         spawnedTile.SetPlayerAreaType(PlayerAreaType);
     }

     if (x <= width && x >= width - tilesPerPlayer)
     {
         PlayerAreaType = 1;
         spawnedTile.SetPlayerAreaType(PlayerAreaType);
     }

     else
     {
         PlayerAreaType = 2;
         spawnedTile.SetPlayerAreaType(PlayerAreaType);
     }
 }

 public int GetPlayerAreaType(TileData spawnedTile)
 {
     return spawnedTile.PlayerAreaType;
 }
 */