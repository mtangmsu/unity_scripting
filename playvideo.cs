using UnityEngine;
using System.Collections;

public class playvideo : MonoBehaviour
{
    private void Start()
    {
        Renderer r = GetComponent<Renderer>();
        MovieTexture movie = (MovieTexture)r.material.mainTexture;
        movie.Play();
        movie.loop = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            Renderer r = GetComponent<Renderer>();
            MovieTexture movie = (MovieTexture)r.material.mainTexture;
            //aud = movie.audioClip;
            movie.loop = true;
            if (movie.isPlaying)
            {
                movie.Pause();
            }
            else {
                movie.Play();
                //movie.audioClip.Play();
                //aud.Play();
                //aud = movie.audioClip;
                //aud.Play();

            }
        }
    }
}