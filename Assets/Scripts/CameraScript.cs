using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject left;
    public GameObject right;

    private float _distance;
    public static float cameraSize;

    public float minimumSize = 30;
    public float bufferSize = 10;
    public float deadzoneSize = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _distance = DistanceCalculation(left, right);
        cameraSize = this.GetComponent<Camera>().orthographicSize;

        this.GetComponent<Camera>().orthographicSize = CameraSizeCalculation(_distance);
    }

    private float DistanceCalculation(GameObject left, GameObject right)
    {
        float heightSquared;
        float widthSquared;

        heightSquared = Mathf.Pow(left.transform.position.y - right.transform.position.y, 2);
        widthSquared = Mathf.Pow(left.transform.position.x - right.transform.position.x, 2);

        return Mathf.Sqrt(heightSquared + widthSquared);
    }

    private float CameraSizeCalculation(float distance)
    {
        if ((distance / 2) + bufferSize <= minimumSize)
        {
            return minimumSize + deadzoneSize;
        }
        else if ((distance / 2) + bufferSize <= cameraSize - deadzoneSize)
        {
            return (distance / 2) + bufferSize + deadzoneSize;
        }
        else if ((distance / 2) + bufferSize >= cameraSize)
        {
            return (distance / 2) + bufferSize;
        }
        else
        {
            return cameraSize;
        }
    }
}
