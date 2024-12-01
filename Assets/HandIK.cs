using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandIK : MonoBehaviour
{
    public Transform ThumbIKTarget;
    public Transform ThumbTip;
    public Transform IndexIKTarget;
    public Transform IndexTip;
    public Transform MiddleIKTarget;
    public Transform MiddleTip;
    public Transform RingIKTarget;
    public Transform RingTip;
    public Transform PinkyIKTarget;
    public Transform PinkyTip;

    public void SynchronizeTargets()
    {
        ThumbIKTarget.position = ThumbTip.position;
        IndexIKTarget.position = IndexTip.position;
        MiddleIKTarget.position = MiddleTip.position;
        RingIKTarget.position = RingTip.position;
        PinkyIKTarget.position = PinkyTip.position;
    }

    private void Start()
    {
        SynchronizeTargets();
    }
}
