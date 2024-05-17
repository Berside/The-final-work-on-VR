using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class move_laser : MonoBehaviour
{
    private GameObject Mech;
    private GameObject Laser;
    public Collider button;
    public int side1 = 1;
    public int side2 = 1;

    private void Awake()
    {
        Mech = GameObject.Find("Mechanism");
        Laser = GameObject.Find("Lazer");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Vector3 newPosition = Mech.transform.localPosition + new Vector3(0, 0, side1 * 0.25f);
            Mech.transform.localPosition = newPosition;
            //Debug.Log(Mech.transform.position.z);
            //Debug.Log(Mech.transform.position.z < -10);
            if (Mech.transform.localPosition.z < -10)
            {
                Mech.transform.localPosition = new Vector3(-7.39f, 1.77f, -10);
            }
            if (Mech.transform.localPosition.z > 0)
            {
                Mech.transform.localPosition = new Vector3(-7.39f, 1.77f, 0);
            }
        }

        moveToX(-0.1f);
        moveToZ(-5);

        //if (button.bounds.Contains(Camera.main.transform.position))
        //{

        //}
    }

    private void moveToZ(float coordZ)
    {
        Vector3 newPosition = Mech.transform.localPosition + new Vector3(0, 0, -0.01f);
        Mech.transform.localPosition = newPosition;
        if (Mech.transform.localPosition.z < coordZ)
        {
            Mech.transform.localPosition = new Vector3(-7.39f, 1.77f, coordZ);
        }
    }
    private void moveToX(float coordX)
    {
        Vector3 newPosition = Laser.transform.localPosition + new Vector3(-0.0002f, 0, 0);
        Laser.transform.localPosition = newPosition;
        if (Laser.transform.localPosition.x < coordX)
        {
            Laser.transform.localPosition = new Vector3(coordX, Laser.transform.localPosition.y, Laser.transform.localPosition.z);
        }
    }

    //private void MoveObjects()
    //{

    //    foreach (GameObject obj in objectsToMove)
    //    {
    //        Vector3 newPosition = obj.transform.position + new Vector3(0.05f, 0, 0);
    //        obj.transform.position = newPosition;
    //    }
    //}
}
