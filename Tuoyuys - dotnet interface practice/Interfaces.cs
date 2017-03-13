using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuoyuys___dotnet_interface_practice
{
    interface IToy
    {
        string Name { get; set; }
    }
    interface IFillable : IToy
    {
        void ChangeFillLevel(int level);
        int GetFillLevel();
    }

    interface IAccelerable : IToy
    {
        void ChangeSpeed(int speed);
        int GetSpeed();
    }

    interface IOpenable : IToy
    {
        void Open(bool opened);
        bool GetOpen();
    }
}
