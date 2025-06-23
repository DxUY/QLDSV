using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV.Be.Interfaces
{
    internal interface IHasData
    {
        DataSet DataSet { get; }
        Dictionary<string, BindingSource> BindingSources { get; }
        Dictionary<string, Stack<DataTable>> RowsBackups { get; }
        object TableAdapterManager { get; }
    }
}
