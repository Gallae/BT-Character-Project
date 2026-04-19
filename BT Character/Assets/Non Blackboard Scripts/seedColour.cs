using UnityEngine;

public class seedColour : MonoBehaviour
{
    public Material[] seedMaterials;
    public int randomColour;
    public colourSet colourOfSeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomColour = Random.Range(0, 3);
        GetComponent<Renderer>().material = seedMaterials[randomColour];
        colourOfSeed = (colourSet)randomColour;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public enum colourSet { blue, red, yellow }