using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    public GameObject[] elementPrefabs;
    public int fieldSize = 5;
    private void Start()
    {
        GenerateField();
    }
    private void GenerateField()
    {
        for (int x = 0; x < fieldSize; x++)
        {
            for (int y = 0; y < fieldSize; y++)
            {
                Vector2 position = new Vector2(x, y);
                int randomIndex = Random.Range(0, elementPrefabs.Length);
                GameObject element = Instantiate(elementPrefabs[randomIndex], position, Quaternion.identity);
                element.transform.SetParent(transform);
            }
        }
    }
}
