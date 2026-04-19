using NodeCanvas.Framework;
using UnityEngine;
using System.Collections.Generic;

public class seedSpawner : MonoBehaviour
{
    public GameObject seed;
    public List<GameObject> seeds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            Vector3 seedPos = new Vector3(Random.Range(-25f, 25f), 0f, Random.Range(-25f, 25f));
            GameObject newSeed = Instantiate(seed);
            newSeed.transform.position = seedPos;
            seeds.Add(newSeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
