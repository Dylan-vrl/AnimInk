using Fusion.XR.Shared.Rig;
using UnityEngine;

namespace Fusion.XR.Shared.Grabbing
{
    /**
     * Networked version of the local Grabber.
     * This networked version is needed to expose the networkTransform to the grabbing logic, to extrapolate properly the visuals (interpolation targets)
     **/

    [DefaultExecutionOrder(NetworkGrabber.EXECUTION_ORDER)]
    public class NetworkGrabber : NetworkBehaviour
    {
        public const int EXECUTION_ORDER = NetworkHand.EXECUTION_ORDER + 10;
        [HideInInspector]
        public NetworkHand hand;

        public override void Spawned()
        {
            base.Spawned();
            hand = GetComponentInParent<NetworkHand>();
            var grab = GetComponentInParent<INetworkGrabber>();
            if (grab != null && grab.IsLocalNetworkRig)
            {
                // References itself in its local counterpart, to simplify the lookup during local grabbing
                if (grab.grabber != null)
                {
                    grab.grabber.networkGrabber = this;
                }
            }
        }
    }
}