using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    float speed = 30.0f;

    [SerializeField]
    private GameObject city;
    [SerializeField]
    private GameObject gallery;

    [SerializeField]
    private Light[] galleryLights;

    private float timer;
    private bool cityVisible;
    [SerializeField]
    private bool halfbeat;
    [SerializeField]
    private AudioSource hey;

    private float bps;
    [SerializeField]
    private int beat;
    [SerializeField]
    private GameObject[] AnimPlanes;
    [SerializeField]
    private GameObject[] Wall;
    [SerializeField]
    private Material blackBat;
    [SerializeField]
    private Material neonBat;
    [SerializeField]
    private Material nullMat;

    public Material NeonBat { get => neonBat; set => neonBat = value; }
    public Material BlackBat { get => blackBat; set => blackBat = value; }

    // Start is called before the first frame update
    void Start()
    {
        city.gameObject.SetActive(false);
        gallery.gameObject.SetActive(true);
        timer = 0.0f;
        cityVisible = false;
        hey.Play();
        beat = 0;
        halfbeat = false;
        bps = 160.0f / 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        beat = (int)(timer * bps);
        if(timer - ((float)beat / bps)  < (1.0f / bps) * 0.5f)
        {
            halfbeat = false;
        }
        else
        {
            halfbeat = true;
        }

        if (timer < 10.0f)
        {
            foreach(Light light in galleryLights)
            {
                light.intensity = 1.5f * ((10.0f - timer)/ 10.0f);
            }
        }
        else if(timer > 10.0f && !cityVisible)
        {

            city.gameObject.SetActive(true);
            gallery.gameObject.SetActive(false);
            cityVisible = true;
        }
        else if (beat == 27)
        {
            Wall[5].GetComponent<Renderer>().material = NeonBat;
        }
        else if(beat == 28)
        {
            Wall[5].GetComponent<Renderer>().material = BlackBat;
        }
        else if(beat == 35)
        {
            Wall[5].GetComponent<Renderer>().material = NeonBat;
        }
        else if(beat == 36)
        {
            Wall[5].GetComponent<Renderer>().material = BlackBat;
        }
        else if (beat == 43)
        {
            Wall[5].GetComponent<Renderer>().material = NeonBat;
        }
        else if(beat == 44)
        {
            Wall[5].GetComponent<Renderer>().material = BlackBat;
        }
        else if(beat == 51)
        {
            Wall[5].GetComponent<Renderer>().material = NeonBat;
        }
        else if(beat == 52)
        {
            Wall[5].GetComponent<Renderer>().material = BlackBat;
        }
        else if(beat == 55 && halfbeat)
        {
            Wall[2].GetComponent<Renderer>().material = BlackBat;
        }
        else if (beat == 56 && !halfbeat)
        {
            Wall[2].GetComponent<Renderer>().material = NeonBat;
        }
        else if(beat == 56 && halfbeat)
        {
            Wall[2].GetComponent<Renderer>().material = nullMat;
            Wall[3].GetComponent<Renderer>().material = BlackBat;
        }
        else if (beat == 57 && !halfbeat)
        {
            Wall[3].GetComponent<Renderer>().material = NeonBat;
        }
        else if (beat == 57 && halfbeat)
        {
            Wall[3].GetComponent<Renderer>().material = nullMat;
            Wall[4].GetComponent<Renderer>().material = BlackBat;
        }
        else if (beat == 58 && !halfbeat)
        {
            Wall[4].GetComponent<Renderer>().material = NeonBat;
        }
        else if (beat == 58 && halfbeat)
        {
            Wall[4].GetComponent<Renderer>().material = nullMat;
            Wall[1].GetComponent<Renderer>().material = BlackBat;
        }
        else if (beat == 59 && !halfbeat)
        {
            Wall[1].GetComponent<Renderer>().material = NeonBat;
        }
        else if (beat == 59 && halfbeat)
        {
            Wall[1].GetComponent<Renderer>().material = nullMat;
            Wall[5].GetComponent<Renderer>().material = BlackBat;
        }
        else if (beat == 60 && !halfbeat)
        {
            Wall[5].GetComponent<Renderer>().material = NeonBat;
        }
        else if (beat == 61 && halfbeat)
        {
            AnimPlanes[0].SetActive(true);
            AnimPlanes[1].SetActive(true);
        }
        else if (beat == 69 && halfbeat)
        {
            AnimPlanes[2].SetActive(true);
            AnimPlanes[3].SetActive(true);
            Wall[5].GetComponent<Renderer>().material = nullMat;
        }
        else if (beat == 77 && halfbeat)
        {
            AnimPlanes[4].SetActive(true);
            AnimPlanes[5].SetActive(true);
        }
        if (beat >= 61)
        {
            AnimPlanes[0].GetComponent<Transform>().Rotate(new Vector3(0.0f, Time.deltaTime * speed, 0.0f));
            AnimPlanes[1].GetComponent<Transform>().Rotate(new Vector3(0.0f, -(Time.deltaTime * speed), 0.0f));
        }

        if (beat >= 69)
        {
            AnimPlanes[3].GetComponent<Transform>().Rotate(new Vector3(0.0f, Time.deltaTime * speed, 0.0f));
            AnimPlanes[2].GetComponent<Transform>().Rotate(new Vector3(0.0f, -(Time.deltaTime * speed), 0.0f));
        }
        if (beat >= 77)
        {
            AnimPlanes[4].GetComponent<Transform>().Rotate(new Vector3(0.0f, Time.deltaTime * speed, 0.0f));
            AnimPlanes[5].GetComponent<Transform>().Rotate(new Vector3(0.0f, -(Time.deltaTime * speed), 0.0f));
        }
    }
}
