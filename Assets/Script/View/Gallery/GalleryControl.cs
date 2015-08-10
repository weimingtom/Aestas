﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GalleryControl : MonoBehaviour {

    public Image black;

	void Start ()
    {
        black.gameObject.SetActive(true);
        black.CrossFadeColor(new Color(0, 0, 0, 1), 0f, true, true);
        black.CrossFadeColor(new Color(0, 0, 0, 0), 0.5f, true, true);
        StartCoroutine(DelayToInvoke.DelayToInvokeDo(() =>
        {
            black.gameObject.SetActive(false);
        }, 0.6f));
    }
	
	void Update ()
    {
	
	}
}