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
        transform.position = transform.position - new Vector3(speed, 0, 0);

    }
    public void positionZup()
    {
        transform.position = transform.position + new Vector3(0, speed, 0);

    }
    public void positionZdown()
    {
        transform.position = transform.position - new Vector3(0, speed, 0);

    }
    public void positionYup()
    {
        transform.position = transform.position + new Vector3(0, 0, speed);

    }
    public void positionYdown()
    {
        transform.position = transform.position - new Vector3(0, 0, speed);

    }
    public void positionAup()
    {
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, angle_speed, 0);
    }
    public void positionAdown()
    {
        transform.localEulerAngles = transform.localEulerAngles - new Vector3(0, angle_speed, 0);
    }
    public void positionBup()
    {
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, 0, angle_speed);
    }
    public void positionBdown()
    {
        transform.localEulerAngles = transform.localEulerAngles - new Vector3(0, 0, angle_speed);
    }
    public void positionCup()
    {
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(angle_speed,0, 0);
    }
    public void positionCdown()
    {
        transform.localEulerAngles = transform.localEulerAngles - new Vector3(angle_speed, 0, 0);
    }
}
