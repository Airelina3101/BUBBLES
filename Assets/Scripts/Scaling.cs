using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    private float mininum = 0.01f;
    private float maximum = 0.8f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(Mathf.Lerp(mininum, maximum, Time.time/5), Mathf.Lerp(mininum, maximum, Time.time/5));
        /*if (transform.localScale.x >= 0.8f)
        {
            //Destroy(gameObject);
        }*/
    }
}
