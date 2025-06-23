using System.Collections.Generic;
using System.Windows.Forms;

namespace QLDSV.Be.Interfaces
{
    internal interface IHasPanel
    {
        Dictionary<string, Panel> Panels { get; }
    }
}
