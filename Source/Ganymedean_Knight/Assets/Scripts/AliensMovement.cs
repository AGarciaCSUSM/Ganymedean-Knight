using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliensMovement : MonoBehaviour
{
    public GameObject Alien1;
    public GameObject Alien2;
    public GameObject Alien3;
    public GameObject Alien4;
    public float speed = 5.0f;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Alien1.transform.position = Vector3.MoveTowards(Alien1.transform.position, Player.transform.position, speed * Time.deltaTime);
        Alien2.transform.position = Vector3.MoveTowards(Alien2.transform.position, Player.transform.position, speed * Time.deltaTime);
        Alien3.transform.position = Vector3.MoveTowards(Alien3.transform.position, Player.transform.position, speed * Time.deltaTime);
        Alien4.transform.position = Vector3.MoveTowards(Alien4.transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
