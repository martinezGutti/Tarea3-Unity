using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5_MoveTimeDelta : MonoBehaviour
{
    private GameObject cube;
    private GameObject sphere;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindWithTag("MY_CUBE");
        sphere = GameObject.FindWithTag("MY_SPHERE");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow)) {
            cube.transform.Translate(0,-speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            cube.transform.Translate(0,speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            cube.transform.Translate(speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            cube.transform.Translate(-speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.S)) {
            sphere.transform.Translate(0,-speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.W)) {
            sphere.transform.Translate(0,speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.D)) {
            sphere.transform.Translate(speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A)) {
            sphere.transform.Translate(-speed * Time.deltaTime,0,0);
        }

    }
}
