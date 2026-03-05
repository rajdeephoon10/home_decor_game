using UnityEngine;

public class FurnitureSpawner : MonoBehaviour
{
    public GameObject sofa;

    public void SpawnSofa()
    {
        Instantiate(sofa, new Vector3(0, 0, 0), Quaternion.identity);
    }
}