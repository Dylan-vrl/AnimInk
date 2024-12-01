using Fusion.Addons.MXPen;
using UnityEngine;

public class CustomHardwareMXPen : HardwareMXPen, IHardwareGrabber
{
    public bool isGrabbing { get; set; }

    protected override void Update()
    {
        base.Update();
#if OCULUS_SDK_AVAILABLE
        if (!OVRPlugin.GetActionStateBoolean("front", out bool front))
        {
            Debug.LogError($"MX_Ink: Error getting action name: front");
        }
        isGrabbing = front;
    }
#endif
}
