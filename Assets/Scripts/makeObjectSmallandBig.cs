using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeObjectSmallandBig : MonoBehaviour
{
    private float timer = 0.0f;
    public float timeToChange=1f;
    bool enlarge = true;
    public GameObject targetObject;
    public float scaleSpeed=1f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToChange)
        {
            enlarge = !enlarge;
            timer = 0.0f;
        }
        else
        {
            if(enlarge)
            {
                Vector3 scale = targetObject.transform.localScale;
                scale += Vector3.one * scaleSpeed * Time.deltaTime;
                targetObject.transform.localScale = scale;
            }
            else
            {
                Vector3 scale = targetObject.transform.localScale;
                scale -= Vector3.one * scaleSpeed * Time.deltaTime;
                targetObject.transform.localScale = scale;
            }
        }
    }
}
