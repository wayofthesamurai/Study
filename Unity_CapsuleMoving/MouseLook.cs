using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {// ����������� ���
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY; // ���������� ��� X � Y RotationAxes ��� ��� ��������

    public float itivityHor = 9.0f; // �������������� ����������������
    public float itivityVert = 9.0f; // �������� ����������������

    public float minimumVert = -45.0f; // ������������� ������������ � ����������� ���� ��������
    public float maximumVert = 45.0f;

    private float _rotationX = 0; // ���� �������� ��� x

    void Start()
    {
        // ������� ���, ����� ������� ���� �� ������ ��������
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true; // ��������� ��������
    }

    void Update()
    {
        if (axes == RotationAxes.MouseX) // ����������, �������� �� ��� �������� ���� X ��� Y
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * itivityHor, 0); // ��������� ������ ��� X � �������� �� ��������������� ����������������
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * itivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); // Mathf.Clamp: ���������� �������� �������� ����� min � max, 
                                                                            // ���� �������� ������ min, ������� min. ���� �������� ������, ��� max, ������� max, ����� ������� ��������

            transform.localEulerAngles = new Vector3(_rotationX, transform.localEulerAngles.y, 0); // localEulerAngles ����������� ���� ������,
                                                                                                   // ������, ��� ���� �������� ������� ������������ ������������� �������. ��� ���������� ����� ������������ ��� ������ � ��������� ����. �� ����� �������������� ��� ����������, ���� ����� ����������������, ���� ���� ��������� 360 ��������.
        }
        else
        {
            float rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * itivityHor;

            _rotationX -= Input.GetAxis("Mouse Y") * itivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}
