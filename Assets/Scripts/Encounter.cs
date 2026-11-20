using UnityEngine;

public class Encounter : MonoBehaviour
{
    public GameObject coinPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SartEncounter()
    {
        Instantiate(coinPrefab, new Vector2(-1, -0.5f),  Quaternion.identity);
        Instantiate(coinPrefab, new Vector2(0, -0.5f),  Quaternion.identity);
        Instantiate(coinPrefab, new Vector2(0, 1),  Quaternion.identity);
    }
    
}
