using UnityEngine;

public class SpawnFurniture : MonoBehaviour
{
    public GameObject sofaPrefab;

    public void SpawnSofa()
    {
        Instantiate(sofaPrefab, new Vector3(0,0,0), Quaternion.identity);
    }
}