using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _light;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("closeLight", 0.5f);
        Invoke("_destroy", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity;
    }
    void closeLight()
    {
        _light.SetActive(false);
    }    
    void _destroy()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }    
}
