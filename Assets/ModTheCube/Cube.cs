using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 3);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 0.4f, 1.0f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(5.0f * Time.deltaTime, 2.0f, 0.0f);
    }
}
