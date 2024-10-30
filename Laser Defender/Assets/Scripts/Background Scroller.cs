using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] RawImage background;
    [SerializeField] float scrollSpeedX = 0.1f;
    [SerializeField] float scrollSpeedY = 0.1f;

    void Update()
    {
        background.uvRect = new Rect(background.uvRect.position + 
                            new Vector2(scrollSpeedX,scrollSpeedY) * Time.deltaTime, 
                            background.uvRect.size);
    }
}
