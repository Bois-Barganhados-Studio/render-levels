using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    private const string _FOLDER = "Maps";
    public string ground = _FOLDER+"/Ground";
    public string groundCorner = _FOLDER+"/Ground_Corner";
    public Vector3 gPosition = new(0, 0, 0); //float numbers
    public Vector3 gcPosition = new(0.32f, 0 , 0);
    public ArrayList list = new ();

    void Start()
    {
        Debug.Log("Running");
        Debug.Log(ground);
        Debug.Log(groundCorner);

        GameObject groundObj = (GameObject)Resources.Load(ground);
        GameObject groundCornerObj = (GameObject)Resources.Load(groundCorner);

        list.Add(GenGameTileMap(groundObj,gPosition));
        list.Add(GenGameTileMap(groundCornerObj, gcPosition));

    }


    GameObject GenGameTileMap(GameObject obj,Vector3 pos)
    {
        GameObject tilemap = Instantiate(obj, pos, Quaternion.identity);
        tilemap.transform.parent = transform;
        return tilemap;
    }
}
