using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    private float _timer = 0f;
    private float minimum = 0.05f;
    private float maximum = 0.8f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        transform.localScale = new Vector2(Mathf.Lerp(minimum, maximum, _timer/5), Mathf.Lerp(minimum, maximum, _timer/5));
        if (transform.localScale.x >=0.8f)
        {
            Destroy(gameObject);
        }
    }
}
