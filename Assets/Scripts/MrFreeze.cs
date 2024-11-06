using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrFreeze : MonoBehaviour, IClickable
{
    [SerializeField] PhysicMaterial _Material;

    Collider _Collider;

    Renderer _renderer;

    Color _ogColour;

    PhysicMaterial _ogMaterial;

    private void Awake()
    {
        _Collider = GetComponent<Collider>();
        _renderer = GetComponent<Renderer>();
        _ogColour = _renderer.material.color;
        _ogMaterial = _Collider.material;
    }

    public void OnClick()
    {
        if (_Collider.material == _ogMaterial)
        {
            _Collider.material = _Material;
            _renderer.material.color = Color.cyan;
        }

        else
        {
            _Collider.material = _ogMaterial;
            _renderer.material.color = _ogColour;
        }
    }

    public void ChangeColour()
    {
        _renderer.material.color = Color.cyan;
    }
}
