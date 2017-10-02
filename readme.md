# Joutai: Script-Based State Machine Management Unity3d
A collection of scripts for managing state transition with GameObject components.

## Usage
* Use one of the examples or make your own child that inherits from "State" or from another of the example states.
* Drag Script onto GameObject. You can use multiple copies.
* Before running the project make sure only one "State" component is Enabled (ticked). That will be the entry state
* use advanceState() in your custom states to move on to the next state.
