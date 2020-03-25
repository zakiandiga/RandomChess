using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoAnimation : MonoBehaviour
{
    const string WhitesPlay = "WhitesPlay";
    const string BlacksPlay = "BlacksPlay";
    public Animator cameraAnimator;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            cameraAnimator.SetTrigger(WhitesPlay);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            cameraAnimator.SetTrigger(BlacksPlay);
        }

    }
}
