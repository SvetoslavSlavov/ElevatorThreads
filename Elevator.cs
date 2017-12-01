using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace myApp
{
    /// <summary>
    ///  Elevator class ， Floor selection method 
    /// </summary>

    public class Elevator
    {

        #region  attribute 

        /// <summary>
        ///  Current floor 
        /// </summary>
        public Floor _floorCurrent;
        /// <summary>
        ///  Full floor 
        /// </summary>
        public List<Floor> _floorAll = new List<Floor>();

        /// <summary>
        ///  I want to stop at the input parameters 
        /// </summary>
        /// <param name="floor"> Floor to stop </param>
        public void CommandStop(Floor floor)
        {
            floor.BoolStop = true;
            GoToTargetFloor();
        }


        /// <summary>
        ///  Lift up operation , Run to floor layer 
        /// </summary>
        /// <param name="floor"></param>
        public void GoUp(Floor floor)
        {
            if (_floorCurrent.Compare(floor) < 0)
            {
                Thread.Sleep(300);
                Console.WriteLine(" Upstream ：" + _floorCurrent.IFloorNo);
                int index = _floorAll.IndexOf(_floorCurrent);
                _floorCurrent = _floorAll[index + 1];
                GoUp(floor);
            }
            else
            {
                Thread.Sleep(500);
                Reach(floor,1);
            }
        }

        /// <summary>
        ///  Elevator down operation 
        /// </summary>
        public void GoDown(Floor floor)
        {
            if (_floorCurrent.Compare(floor) > 0)
            {
                Thread.Sleep(300);
                Console.WriteLine(" Down ：" + _floorCurrent.IFloorNo);
                int index = _floorAll.IndexOf(_floorCurrent);
                _floorCurrent = _floorAll[index - 1];
                GoDown(floor);
            }
            else
            {
                Thread.Sleep(500);
                Reach(floor,1);
            }
        }

        /// <summary>
        ///  Go to command layer , Is there a command layer for the loop list 
        /// </summary>
        public void GoToCommandFloor()
        {
            foreach (var item in _floorAll)
            {
                if (item.GetStatus())
                {
                    if (_floorCurrent.Compare(item) < 0)
                    {
                        GoUp(item);
                    }
                    else if (_floorCurrent.Compare(item) > 0)
                    {
                        GoDown(item);
                    }
                }
            }
        }

        /// <summary>
        ///  Go to the target floor 
        /// </summary>
        public void GoToTargetFloor()
        {

            foreach (var item in _floorAll)
            {
                if (item.GetStatusFlag() == 0)
                {
                    if (_floorCurrent.Compare(item) < 0)
                    {
                        GoUp(item);
                    }
                    else if (_floorCurrent.Compare(item) > 0)
                    {
                        GoDown(item);
                    }
                }
            }
        }


        /// <summary>
        ///  Arrival floor command 
        /// </summary>
        public void Reach(Floor f,int a)
        {
            // int agent;
            if (f.IFloorNo == 1 && a==1)
            {
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
                System.Console.WriteLine("---------Confidential Agent---------");
            }
            else if (f.IFloorNo == 2 && a==2)
            {
                System.Console.WriteLine("---------Confidential Agent---------");
                Console.WriteLine(" Elevator door can't open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 3 && a==3)
            {
                System.Console.WriteLine("---------Confidential Agent---------");
                Console.WriteLine(" Elevator door can't open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 4 && a==4)
            {
                System.Console.WriteLine("---------Confidential Agent---------");
                Console.WriteLine(" Elevator door can't open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 1 && a==1)
            {
                System.Console.WriteLine("---------Secret Agent---------");
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 2 && a==2)
            {
                System.Console.WriteLine("---------Secret Agent---------");
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 3 && a==3)
            {
                System.Console.WriteLine("---------Secret Agent---------");
                Console.WriteLine(" Elevator door can't open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 4 && a==4)
            {
                System.Console.WriteLine("---------Secret Agent---------");
                Console.WriteLine(" Elevator door can't open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 1 && a==1)
            {
                System.Console.WriteLine("---------Super Agent---------");
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 2 && a==2)
            {
                System.Console.WriteLine("---------Super Agent---------");
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 3 && a==3)
            {
                System.Console.WriteLine("---------Super Agent---------");
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
            }
            else if (f.IFloorNo == 4&&a==4)
            {
                System.Console.WriteLine("---------Super Agent---------");
                Console.WriteLine(" Elevator door can open , Now floor ：" + f.IFloorNo);
            }
            f.Refresh();
        }

    }
}