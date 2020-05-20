using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class ShowStat : Form
    {
        private Dictionary<string, float> vals;
        string Col_1;
        string Col_2;
        public ShowStat()
        {
            InitializeComponent();
        }

        public void SetData(Dictionary<string,float> vals,string Col_1,string Col_2)
        {
            this.vals = vals;
            this.Col_1 = Col_1;
            this.Col_2 = Col_2;
            dataGridView1.Columns[0].HeaderText = Col_1;
            dataGridView1.Columns[1].HeaderText = Col_2;
            foreach (KeyValuePair<string,float> val in vals)
            {
                dataGridView1.Rows.Add(val.Key, val.Value);
            }
        }
    }
}
