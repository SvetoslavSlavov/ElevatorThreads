using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace myApp
{
  /// <summary>
  ///  Floor class ， Each floor has an up and down command and down stairs command 
  /// </summary>
  public class Floor
  {
    Elevator elevator;
    /// <summary>
    ///  Floor number 
    /// </summary>
    private int _iFloorNo;
 
    public int IFloorNo
    {
      get { return _iFloorNo; }
      set { _iFloorNo = value; }
    }
    /// <summary>
    ///  Upstream demand 
    /// </summary>
    private bool _boolUp = false;
    /// <summary>
    ///  Downstream demand 
    /// </summary>
    private bool _boolDown = false;
 
    private bool _boolStop = false;
 
    public bool BoolStop
    {
      get { return _boolStop; }
      set { _boolStop = value; }
    }
 
    #region  Constructor 
     
    
    public Floor(int f,Elevator e)
    {
      _iFloorNo = f;
      elevator = e;
    }
 
    public Floor(int f)
    {
      _iFloorNo = f;
    }
 
    public Floor()
    {
    }
 
    /// <summary>
    ///  Get the floor to dock ， Command layer 
    /// </summary>
    /// <returns> Stop true； too false；</returns>
    public bool GetStatus()
    {
      return _boolDown || _boolUp;
    }
 
    /// <summary>
    ///  Ascending return 1； Descending return -1； This layer is returned to the destination. 0；
    /// </summary>
    /// <returns></returns>
    public int GetStatusFlag()
    {
      if (_boolDown)
      {
        return -1;
      }
      else if(_boolUp)
      {
        return 1;
      }
      else if(_boolStop)
      {
        return 0;
      }
      else
      {
        return -999;
      }
 
    }
 
    /// <summary>
    ///  Upstairs command 
    /// </summary>
    public void CommandUp()
    {
      _boolUp = true;
      elevator.GoToCommandFloor();
    }
 
    /// <summary>
    ///  Downstairs command 
    /// </summary>
    public void CommandDown()
    {
      _boolDown = true;
      elevator.GoToCommandFloor();
    }
 
    /// <summary>
    ///  Floor to state refresh 
    /// </summary>
    public void Refresh()
    {
      _boolUp = false;
      _boolDown = false;
      _boolStop = false;
    }
 
 
    /// <summary>
    ///  Floor to floor 
    /// </summary>
    /// <param name="floor"></param>
    /// <returns></returns>
    public int Compare(Floor floor)
    {
      int result = 1;
      if (this._iFloorNo > floor._iFloorNo)
      {
        result = 1;
      }
      else if (this._iFloorNo < floor._iFloorNo)
      {
        result = -1;
      }
      else
      {
        result = 0;
      }
      return result;
    }
  }
}
