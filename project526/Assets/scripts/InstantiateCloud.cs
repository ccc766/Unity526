using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCloud : MonoBehaviour
{
    public GameObject cloud;
    float x_random;
    float time = 2;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        x_random = Random.Range(-50f, -450f);
        time -= Time.deltaTime;
        if (time <= 0f)
        {
            GameObject gameobj = Instantiate(cloud);
            gameobj.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + 150, Screen.height + x_random, 10));
            time = 2f;
        }
    }
}
