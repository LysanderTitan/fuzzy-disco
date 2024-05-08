using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderSpawner : MonoBehaviour
{
    public GameObject orangeDi;
    public GameObject greenDi;
    public Transform spawnPoint;
    public List<int> points; 
    public int greenDiCost = 20; // The cost to buy a green unit
    public int orangeDiCost = 10; // The cost to buy an orange unit
    public TMP_Text pointsText; 

    void Start()
    {
        StartCoroutine(AddPointsEverySecond());
    }

    void Update() 
    {
        pointsText.text = "Points: " + points.Count;
    }

    IEnumerator AddPointsEverySecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            points.Add(1); 
        }
    }

    public void SpawnGreenDI()
    {
        if (points.Count >= greenDiCost)
        {
            points.RemoveRange(0, greenDiCost);
            Instantiate(greenDi, spawnPoint.position, Quaternion.identity);
        }
    }

    public void SpawnOrangeDi()
    {
        if (points.Count >= orangeDiCost)
        {
            points.RemoveRange(0, orangeDiCost);
            Instantiate(orangeDi, spawnPoint.position, Quaternion.identity);
        }
    }
}
