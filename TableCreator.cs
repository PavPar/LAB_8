using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public class TableCreator
    {
        DataGridView tbl;
        public TableCreator(DataGridView tbl)
        {
            this.tbl = tbl;
            
        }

        public void CreateRow(string course, string groupID, string LastName, string checkBookID, string study, string mark)
        {
            tbl.Rows.Add(course, groupID, LastName, checkBookID, study, mark);
        }

        public void ClearRows()
        {
            //for(int i = 2;i < tbl.Rows.Count; i++)
            //{
            //    tbl.Rows.Remove(tbl.Rows[i]);
            //}

            tbl.Rows.Clear();
        }
    }
}
