using System.Collections;
using System.Collections.Generic;
using Fusion.XR.Shared.Grabbing;
using UnityEngine;

public interface INetworkGrabber
{
    public bool IsLocalNetworkRig { get; }
    public Grabber grabber { get; }
}
