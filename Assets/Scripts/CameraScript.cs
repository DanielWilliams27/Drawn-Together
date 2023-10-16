using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject left;
    public GameObject right;

    private float distance;

    public float minimumSize = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = DistanceCalculation(left, right);

        this.GetComponent<Camera>().orthographicSize = CameraSizeCalculation(distance);
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
        if ((distance / 2) + 10 <= minimumSize)
        {
            return minimumSize;
        }
        else
        {
            return (distance / 2) + 10;
        }
    }
}
