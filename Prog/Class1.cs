using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog
{
    class Class1
    {
        public static int GETID(DataGridView DataList)
        {
            int id = Convert.ToInt32((DataList.CurrentRow.DataBoundItem as DataRowView).Row.ItemArray[0]);
            return id;
        }
    }
}
