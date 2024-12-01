# AnimInk

AnimInk s an innovative VR application that enables users to collaborate in real-time by interacting with shared 3D models and draw annotations thanks to the MX Ink stylus. 
Designed for creative and interactive experiences, the app leverages the Meta XR SDK for immersive VR functionality and Fusion 2 for seamless multiplayer networking.

It has been primarily designed for 3D animators. Using VR to quickly prototype the poses of your animations allows the animator to get a better perspective over their
3D model. The stylus provides a precise interaction with the mesh and allows for an efficiient collaboration thanks to annotations.

## Features
- Real-Time Collaboration: Multiple users can interact with the same 3D environment simultaneously.
- MX Ink Stylus Integration: Use the stylus for all interactions, including:
  - Grabbing IK Targets: Move targets to manipulate models and match specific poses.
  - Drawing: Create 3D sketches in the VR space.

## Requirements

- Meta Quest 2, 3 or 3S
- MX Ink stylus
- Unity 2022.3.X
- Meta XR SDK (pre-installed)
- Fusion 2 (pre-configured)

## Get started:
- Download this repo and open it in Unity
- Set Up Fusion 2:
  - Ensure you have an active Fusion 2 account.
  - Configure the Photon settings with your app's unique ID in the Fusion Dashboard.
- Build the game
- Upload the apk to your headset (which is paired to the stylus)

## Usage
- The front button is used to grab objects in range. Blue boxes are all grabbable.
- The middle button is used to draw.
- Alternately, tip can be used to draw
- Click on the back button to confirm your drawing. You can then move it using the newly created blue box.
