using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JTRP.Utility;

public class _test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renderers = transform.GetComponentsInChildrenDeep<Renderer>();
        Debug.Log(renderers);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
