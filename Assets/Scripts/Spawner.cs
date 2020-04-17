using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public float Interval;

    public float FromX;
    public float ToX;
    public float FromY;
    public float ToY;


    public float _timer;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        _timer = 1;
        Time.timeScale = 1;
    }
    void Update()
    {
        _timer -= Time.fixedDeltaTime;

        if (_timer > 0)
            return;

        _timer += Interval;
        var position = transform.position;
        position.x += Random.Range(FromX, ToX);
        position.y += Random.Range(FromY, ToY);
        
        Instantiate(Prefab, position, Quaternion.identity);
    }
}
