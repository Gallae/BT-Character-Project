using UnityEngine;

public class seedColour : MonoBehaviour
{
    public enum setColour { blue, red, yellow }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randomNum = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
