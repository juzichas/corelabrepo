using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class movemnt : MonoBehaviour
{
    public float speed;
    public float timer;
    public GameObject circle; //click and drag circle onto my movment, into CIRCLE space.
    float posx;
    float posy;
    public float freq;
    public float amp;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
        speed = 5;
        timer = 0;
        freq = 1;
        amp = 1;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(New Vector2(1,0)*
        //Time.time is constantly going up from start of game. Time.deltatime, is time between frame- usually smaller number

        if (timer >= 1)
        {
            transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
            timer = 0;
        }
        timer += Time.deltaTime;
        posx = Mathf.Sin(Time.time * freq) * amp;
        posy = Mathf.Cos(Time.time * freq) * amp;
        Debug.Log(posx);

        circle.transform.position = new Vector2(transform.position.x + posy, posy + transform.position.y);

    }
}
