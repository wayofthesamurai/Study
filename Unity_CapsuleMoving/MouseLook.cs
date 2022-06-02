using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {// ѕеречислить оси
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY; // ќпределить оси X и Y RotationAxes как оси вращени€

    public float itivityHor = 9.0f; // √оризонтальна€ чувствительность
    public float itivityVert = 9.0f; // изменить чувствительность

    public float minimumVert = -45.0f; // ”станавливаем максимальный и минимальный угол поворота
    public float maximumVert = 45.0f;

    private float _rotationX = 0; // угол поворота оси x

    void Start()
    {
        // —делаем так, чтобы твердое тело не мен€ло вращение
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true; // «акрепить вращение
    }

    void Update()
    {
        if (axes == RotationAxes.MouseX) // ќпредел€ем, €вл€етс€ ли ось вращени€ осью X или Y
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * itivityHor, 0); // ¬ращаемс€ вокруг оси X и умножаем на соответствующую чувствительность
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * itivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); // Mathf.Clamp: ограничить значение значени€ между min и max, 
                                                                            // ≈сли значение меньше min, вернуть min. ≈сли значение больше, чем max, вернуть max, иначе вернуть значение

            transform.localEulerAngles = new Vector3(_rotationX, transform.localEulerAngles.y, 0); // localEulerAngles собственный угол Ёйлера,
                                                                                                   // —кажем, это угол поворота объекта относительно родительского объекта. Ёту переменную можно использовать дл€ чтени€ и установки угла. Ќе может использоватьс€ дл€ приращени€, угол будет недействительным, если угол превышает 360 градусов.
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
