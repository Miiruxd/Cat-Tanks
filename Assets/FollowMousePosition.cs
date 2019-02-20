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

        transform.rotation = homeRotation;

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if ((mousePos.x < pivotPos.x && mousePos.y > pivotPos.y) || (mousePos.x > pivotPos.x && mousePos.y < pivotPos.y))
        {
            mousePos.x = pivotPos.x;
            mousePos.y = pivotPos.y;
        }

        float rotation_angle_rad = Mathf.Atan2(Mathf.Abs(mousePos.y - pivotPos.y), Mathf.Abs(mousePos.x - pivotPos.x));

        transform.Rotate(0, 0, rotation_angle_rad * Mathf.Rad2Deg);

        //Debug.Log(transform.rotation.eulerAngles);
    }
}
