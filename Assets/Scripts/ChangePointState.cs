using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePointState : MonoBehaviour
{

    float speed = 0.5F;
    float angle_speed = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void positionXup()
    {

        transform.position = transform.position + new Vector3(speed, 0, 0);

    }
    public void positionXdown()
    {

        //transform.Translate(-speed, 0, 0);
        transform.position = transform.position - new Vector3(speed, 0, 0);

    }
    public void positionZup()
    {

        //transform.Translate(0, speed, 0);
        transform.position = transform.position + new Vector3(0, speed, 0);

    }
    public void positionZdown()
    {

        //transform.Translate(0, -speed, 0);
        transform.position = transform.position - new Vector3(0, speed, 0);

    }
    public void positionYup()
    {

        //transform.Translate(0, 0, speed);
        transform.position = transform.position + new Vector3(0, 0, speed);

    }
    public void positionYdown()
    {

        //transform.Translate(0, 0, -speed);
        transform.position = transform.position - new Vector3(0, 0, speed);

    }
    public void positionAup()
    {
        //transform.Rotate(new Vector3(0, angle_speed, 0));
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, angle_speed, 0);
    }
    public void positionAdown()
    {
        //transform.Rotate(new Vector3(0, -angle_speed, 0));
        transform.localEulerAngles = transform.localEulerAngles - new Vector3(0, angle_speed, 0);
    }
    public void positionBup()
    {
        //transform.Rotate(new Vector3(0, 0, angle_speed));
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, 0, angle_speed);
    }
    public void positionBdown()
    {
        //transform.Rotate(new Vector3(0, 0, -angle_speed));

        transform.localEulerAngles = transform.localEulerAngles - new Vector3(0, 0, angle_speed);
    }
    public void positionCup()
    {
        //transform.Rotate(new Vector3(angle_speed, 0, 0));
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(angle_speed,0, 0);
    }
    public void positionCdown()
    {
        //transform.Rotate(new Vector3(-angle_speed, 0, 0));
        transform.localEulerAngles = transform.localEulerAngles - new Vector3(angle_speed, 0, 0);
    }
}
