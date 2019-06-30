﻿namespace rovers
{
    public class MoveWest : IMove
    {
        public Rover Execute(Rover rover){
            if (rover.CurrentPoint.Left != null){
                rover.CurrentPoint.RoverOn = null;
                rover.CurrentPoint.Left.RoverOn = rover;
                rover.CurrentPoint = rover.CurrentPoint.Left;
            }

            return rover;
        }
    }
}