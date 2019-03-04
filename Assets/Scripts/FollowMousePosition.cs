using UnityEngine;

public class FollowMousePosition : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 pivotPos;
    private Quaternion homeRotation;

    void Start()
    {
        pivotPos = transform.position;
        homeRotation = transform.rotation;
    }

    void Update()
    {
        if (mousePos == Camera.main.ScreenToWorldPoint(Input.mousePosition))
            return;

        

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float rotation_angle_rad;

        if (mousePos.x > pivotPos.x && mousePos.y < pivotPos.y) //fourth
        {
            mousePos.x = pivotPos.x;
            mousePos.y = pivotPos.y;
        }

        if (mousePos.x < pivotPos.x && mousePos.y < pivotPos.y) //third
            rotation_angle_rad = 90 * Mathf.Deg2Rad - Mathf.Atan2(Mathf.Abs(mousePos.y - pivotPos.y), Mathf.Abs(mousePos.x - pivotPos.x));
        else if (mousePos.x < pivotPos.x && mousePos.y > pivotPos.y) //second
            rotation_angle_rad = 90 * Mathf.Deg2Rad;
        else //first
            rotation_angle_rad = Mathf.Atan2(Mathf.Abs(mousePos.y - pivotPos.y), Mathf.Abs(mousePos.x - pivotPos.x));

        if (rotation_angle_rad < 1.047f)
        {
            transform.rotation = homeRotation;
            transform.Rotate(0, 0, rotation_angle_rad * Mathf.Rad2Deg);
        }

        //Debug.Log(transform.rotation.eulerAngles);
    }
}
