![joutai logo](https://github.com/joobei/Joutai/wiki/joutai-logo.png)
# Joutai: Script-Based State Machine Management for Unity3D
A collection of scripts for managing state transition.

## Usage
* Use one of the examples or make your own class that inherits from "State" or from another example states.
* Drag the script onto an Empty/GameObject. You can use multiple copies but they should all sit in the same Empty/GameObject.
* Each state enables its "neededObjects" on startup and disables every other gameObject except those tagged "permanent". Permanent GameObjects are meant to be objects that handle game logic/networking etc.
  * To avoid your gameobjects becoming disabled create a new tag called "permanent" and add it to all the objects that should not be disabled/hidden.
* Before running the project make sure only one "State" component is Enabled (ticked). That will be the entry state

Check out the [Wiki](https://github.com/joobei/Joutai/wiki) for more info:

## Intro Video
<a href="https://youtu.be/UAwgl4wG3yg" target="_blank"><img src="https://github.com/joobei/Joutai/wiki/youtube-thumbnail.png" 
alt="joutai video tutorial" width="240" height="180" border="10" /></a>
