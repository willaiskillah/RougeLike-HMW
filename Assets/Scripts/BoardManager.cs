using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardManager : MonoBehaviour
{
    public int width;
    public int height;
    private Tilemap board;
    public Tile[] tiles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        board = GetComponentInChildren<Tilemap>();

        for (int i = -4; i <= 3; i++)//x
            for (int j = -4; j <= 3; j++)//y
            {
                print("i: " + i + ", j: " + j);
                Vector3Int coordinate = new Vector3Int(i, j, 0);
            

        int random = Random.Range(0, tiles.Length - 1);
        board.SetTile(coordinate, tiles[random]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}