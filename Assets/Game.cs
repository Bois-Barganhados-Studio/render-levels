using UnityEngine;

public class Game : MonoBehaviour
{
    //public string tileMap1PrefabPath = "Sprites/TileTest";
    //public string tileMap2PrefabPath = "Sprites/TileTest2";
    public string isometric = "Maps/Isometric";

    void Start()
    {
        //Debug.Log(Resources.Load(tileMap1PrefabPath));
        // GameObject tileMap1Prefab = (GameObject)Resources.Load(tileMap1PrefabPath);
        // GameObject tileMap2Prefab = (GameObject)Resources.Load(tileMap2PrefabPath);
        //  Debug.Log(tileMap1Prefab);

        GameObject isometricObj = (GameObject)Resources.Load(isometric);

        GameObject newTileMap1 = Instantiate(isometricObj, transform.position, Quaternion.identity);
        newTileMap1.transform.parent = transform;

        //GameObject newTileMap2 = Instantiate(tileMap2Prefab, transform.position, Quaternion.identity);
       // newTileMap2.transform.parent = transform;

    }
}
