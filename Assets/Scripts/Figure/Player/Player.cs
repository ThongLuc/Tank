using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int _idPlayer;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GameObject _bullet1, _bullet3;
    int move;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb.velocity = new Vector2(0, 2f);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0f);
            move = 8;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            _rb.velocity = new Vector2(0, -2f);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -180f);
            move = 2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            _rb.velocity = new Vector2(-2f, 0);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 90f);
            move = 4;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.velocity = new Vector2(2f, 0);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -90f);
            move = 6;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _rb.velocity = new Vector2(0, 0);
        }    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet;
            if (_idPlayer == 1)
            {
                newBullet = Instantiate(_bullet1, transform.position, _bullet1.transform.rotation);
            }
            else
            {
                newBullet = Instantiate(_bullet3, transform.position, _bullet3.transform.rotation);
            }

            if (move == 2)
            {
                newBullet.GetComponent<Bullet>().velocity = new Vector3(0, -0.05f, 0);
                newBullet.transform.position = new Vector3(transform.position.x, transform.position.y - 5f, newBullet.transform.position.z);
                newBullet.transform.eulerAngles = new Vector3(newBullet.transform.eulerAngles.x, newBullet.transform.eulerAngles.y, 0f);
            }
            else if (move == 8)
            {
                newBullet.GetComponent<Bullet>().velocity = new Vector3(0, 0.05f, 0);
                newBullet.transform.position = new Vector3(transform.position.x, transform.position.y + 5f, newBullet.transform.position.z);
                newBullet.transform.eulerAngles = new Vector3(newBullet.transform.eulerAngles.x, newBullet.transform.eulerAngles.y, -180f);
            }
            else if (move == 4)
            {
                newBullet.GetComponent<Bullet>().velocity = new Vector3(-0.05f, 0, 0);
                newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, newBullet.transform.position.z);
                newBullet.transform.eulerAngles = new Vector3(newBullet.transform.eulerAngles.x, newBullet.transform.eulerAngles.y, 90f);
            }
            else
            {
                newBullet.GetComponent<Bullet>().velocity = new Vector3(0.05f, 0, 0);
                newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, newBullet.transform.position.z);
                newBullet.transform.eulerAngles = new Vector3(newBullet.transform.eulerAngles.x, newBullet.transform.eulerAngles.y, -90f);
            }
        }
    }
}
