using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsConlroller : MonoBehaviour {

    LinkedList<GameObject> ballList;

    float speed = 0.5F;
    float angle_speed = 5;

    GameObject selectedBall;

    // Use this for initialization
    void Start () {

        ballList = new LinkedList<GameObject>();
        selectedBall = GameObject.Find("ball");
        ballList.AddFirst(selectedBall);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "ball")
                {
                    Behaviour halo = (Behaviour)selectedBall.GetComponent("Halo");
                    halo.enabled = false;
                    selectedBall = hit.collider.gameObject;
                    halo = (Behaviour)selectedBall.GetComponent("Halo");
                    halo.enabled = true;

                }
            }
        }
    }
    public void AddPoint()
    {
        GameObject ball = ballList.Last.Value;
        GameObject ballNext = Instantiate(ball, ball.transform.position, ball.transform.rotation, ball.transform.parent);
        ballNext.transform.position = ballNext.transform.position + new Vector3(0.5F, 0, 0);
        ballNext.name = "ball" + ballList.Count.ToString();
        
        ballList.AddLast(ballNext);
        selectedBall = ballNext;
        Behaviour halo = (Behaviour)ball.GetComponent("Halo");
        halo.enabled = false;
    }

    public void positionXup()
    {
        selectedBall.transform.position = selectedBall.transform.position + new Vector3(speed, 0, 0);
    }
    public void positionXdown()
    {
        selectedBall.transform.position = selectedBall.transform.position - new Vector3(speed, 0, 0);

    }
    public void positionZup()
    {
        selectedBall.transform.position = selectedBall.transform.position + new Vector3(0, speed, 0);

    }
    public void positionZdown()
    {
        selectedBall.transform.position = selectedBall.transform.position - new Vector3(0, speed, 0);

    }
    public void positionYup()
    {
        selectedBall.transform.position = selectedBall.transform.position + new Vector3(0, 0, speed);
    }
    public void positionYdown()
    {
        selectedBall.transform.position = selectedBall.transform.position - new Vector3(0, 0, speed);

    }
    public void positionAup()
    {
        selectedBall.transform.localEulerAngles = selectedBall.transform.localEulerAngles + new Vector3(0, angle_speed, 0);
    }
    public void positionAdown()
    {
        selectedBall.transform.localEulerAngles = selectedBall.transform.localEulerAngles - new Vector3(0, angle_speed, 0);
    }
    public void positionBup()
    {
        selectedBall.transform.localEulerAngles = selectedBall.transform.localEulerAngles + new Vector3(0, 0, angle_speed);
    }
    public void positionBdown()
    {
        selectedBall.transform.localEulerAngles = selectedBall.transform.localEulerAngles - new Vector3(0, 0, angle_speed);
    }
    public void positionCup()
    {
        selectedBall.transform.localEulerAngles = selectedBall.transform.localEulerAngles + new Vector3(angle_speed, 0, 0);
    }
    public void positionCdown()
    {
        selectedBall.transform.localEulerAngles = selectedBall.transform.localEulerAngles - new Vector3(angle_speed, 0, 0);
    }
}
