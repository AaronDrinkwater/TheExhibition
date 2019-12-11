using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject city;
    [SerializeField]
    private GameObject gallery;

    [SerializeField]
    private Light[] galleryLights;

    private float timer;
    private bool cityVisible;
    [SerializeField]
    private AudioSource hey;
    // Start is called before the first frame update
    void Start()
    {
        city.gameObject.SetActive(false);
        gallery.gameObject.SetActive(true);
        timer = 0.0f;
        cityVisible = false;
        hey.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 10.0f)
        {
            foreach(Light light in galleryLights)
            {
                light.intensity = 1.5f * ((10.0f - timer)/ 10.0f);
            }
        }
        if (timer > 10.0f && !cityVisible)
        {

            city.gameObject.SetActive(true);
            gallery.gameObject.SetActive(false);
            cityVisible = false;
        }


    }
}
