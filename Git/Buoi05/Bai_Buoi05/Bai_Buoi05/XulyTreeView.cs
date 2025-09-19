using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Buoi05
{
    public class XulyTreeView
    {
        public XulyTreeView()
        {
        }
        public bool Isvalid(TreeNode node, string ten)
        {
            foreach (TreeNode item in node.Nodes)
            {
                if (item.Text == ten)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
