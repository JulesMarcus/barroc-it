using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barroc_IT
{
    class DataGridViewHelper
    {
        public DataGridViewHelper()
        { 
            
        }

        public void LoadInfo(TabPage tabpage, int sizeStringArray, DataGridView datagrid)
        {
            TextBox[] textboxArray = tabpage.Controls.OfType<TextBox>().ToArray();
            TextBox[] mirroredTextArray = textboxArray.Reverse<TextBox>().ToArray();
            string[] datagrid_Row_Text = new string[sizeStringArray];
            for (int i = 0; i < datagrid_Row_Text.Length; i++)
            {
                datagrid_Row_Text[i] = datagrid.Rows[i + 1].Cells["Column2"].Value.ToString();
            }
            for (int i = 0; i < mirroredTextArray.Length; i++)
            {
                mirroredTextArray[i].Text = datagrid_Row_Text[i];
            }
        }
        public void LoadProject()
        { 
        
        }

        public void LoadProjects()
        { 
            
        }
    }
}
