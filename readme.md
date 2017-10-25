# Joutai: Script-Based State Machine Management for Unity3D
A collection of scripts for managing state transition.

## Usage
* Use one of the examples or make your own child that inherits from "State" or from another of the example states.
* Drag Script onto GameObject. You can use multiple copies.
* Each state enables its "neededObjects" on startup and disables every other gameObject except those tagged "permanent". Permanent gameObject are meant to be objects that handle game logic/networking etc.
* Before running the project make sure only one "State" component is Enabled (ticked). That will be the entry state

Check out the wiki for more info:
[Joutai Wiki](https://github.com/joobei/Joutai/wiki)

## Intro Video
Coming soon.
