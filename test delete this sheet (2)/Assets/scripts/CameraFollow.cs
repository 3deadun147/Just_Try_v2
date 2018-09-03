using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform birdTransform;
    Vector3 range;

    void Awake()
    {
        //Calculate the range between the Camera's position and the Bird's position
        range = transform.position - birdTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make the Camera follow the Bird's movement on the X axis
        //And keep the y position constant
        if (birdTransform.position.x <= 8.1f)
        {
            transform.position = new Vector3(0, 0, -9.999999f);
        }


        else if (birdTransform.position.x > 8.1f)
        {
            transform.position = new Vector3(17.68493f, 0, -9.999999f);

        }
       else if (birdTransform.position.x > 8.1f)
        {
            transform.position = new Vector3(35.5f, 0, -9.999999f);
        }


        else
        {
            transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
        }

        if (birdTransform.position.x > 26.1f)
        {
            transform.position = new Vector3(35.48f, 0, -10f);
        }
        if(birdTransform.position.x > 43.8f)
        {
            transform.position = new Vector3(53.32f, 0, -10f);
        }
        if (birdTransform.position.x > 61.57f)
        {
            transform.position = new Vector3(71.2f, 0, -10f);
        }
    }
}