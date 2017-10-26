![joutai logo](https://github.com/joobei/Joutai/wiki/joutai-logo.png)
# Joutai: Script-Based State Machine Management for Unity3D
A collection of scripts for managing state transition.

## Usage
* Use one of the examples or make your own class that inherits from "State".
* Drag the script onto an Empty. You can have multiple copies of the same state but they should all be in the same GameObject.
* Each state enables its 'neededObjects' on startup and disables every other gameObject except those tagged "permanent". Tag "permanent" those GameObjects that handle game logic/networking etc so that they remain active.
* Before running the project make sure only one "State" component is Enabled (ticked). That will be the entry state

## Intro Video
<a href="https://youtu.be/UAwgl4wG3yg" target="_blank"><img src="https://github.com/joobei/Joutai/wiki/youtube-thumbnail.png"/></a>

Check out the [Wiki](https://github.com/joobei/Joutai/wiki) for more info.
