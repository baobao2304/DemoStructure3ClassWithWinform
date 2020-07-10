using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThietKeControl
{
    public class tbSoDienThoai : TextBox
    {
        public tbSoDienThoai()
        {
            this.KeyPress += tbSoDienThoai_KeyPress;
        }

        private void tbSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {  
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
        }
    }
}
