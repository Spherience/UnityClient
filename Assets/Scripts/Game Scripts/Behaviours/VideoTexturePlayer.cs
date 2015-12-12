using UnityEngine;
using System.Collections;

public class VideoTexturePlayer : MonoBehaviour
{

    [SerializeField] private Renderer _renderer;

    void Start()
    {
        var movieTexture = _renderer.material.mainTexture as MovieTexture;
        movieTexture.Play();        
    }
}
