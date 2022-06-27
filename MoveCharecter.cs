using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCharecter : MonoBehaviour {


    [SerializeField] private Transform _Player;
    [SerializeField] private VariableJoystick _Joystick;

    [SerializeField, Range (0, 20)] private float _MoveSpeed;

    void FixedUpdate() {
        Vector3 direction = Vector3.back * _Joystick.Vertical + Vector3.left * _Joystick.Horizontal;
        _Player.Translate(direction * _MoveSpeed * Time.fixedDeltaTime);
    }
}
