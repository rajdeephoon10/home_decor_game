using UnityEngine;

public class WallColorChanger : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    public Material redMat;
    public Material blueMat;
    public Material whiteMat;

    public void SetRed()
    {
        wall1.GetComponent<Renderer>().material = redMat;
        wall2.GetComponent<Renderer>().material = redMat;
        wall3.GetComponent<Renderer>().material = redMat;
    }

    public void SetBlue()
    {
        wall1.GetComponent<Renderer>().material = blueMat;
        wall2.GetComponent<Renderer>().material = blueMat;
        wall3.GetComponent<Renderer>().material = blueMat;
    }

    public void SetWhite()
    {
        wall1.GetComponent<Renderer>().material = whiteMat;
        wall2.GetComponent<Renderer>().material = whiteMat;
        wall3.GetComponent<Renderer>().material = whiteMat;
    }
}