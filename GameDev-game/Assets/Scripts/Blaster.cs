using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    public GameObject blasterPew;
    public float coolDown = 2.5f;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
        Instantiate(blasterPew, transform.position, Quaternion.identity);
        timer = coolDown;
        }
    }
}
