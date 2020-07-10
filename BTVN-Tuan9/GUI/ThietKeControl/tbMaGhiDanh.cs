using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class tbMaGhiDanh : TextBox
    {
        public tbMaGhiDanh()
        {
            this.LostFocus += TbMaGhiDanh_LostFocus;
        }

        private void TbMaGhiDanh_LostFocus(object sender, EventArgs e)
        {
            if(this.Text != string.Empty)
            {
                if(this.Text.Length == 8)
                {
                    string kt3KyTuDauLaChu = this.Text.Substring(0, 3);
                    string kt5KyTuSauLaSo = this.Text.Substring(3,5);
                    foreach(char c in kt3KyTuDauLaChu)
                    {
                        if(!char.IsLetter(c))
                        {
                            MessageBox.Show("3 ký tự đầu phải là chữ");
                            
                            return;
                        }
                    }
                    foreach(char c in kt5KyTuSauLaSo)
                    {
                        if(!char.IsDigit(c))
                        {
                            MessageBox.Show("5 ký tự đầu phải là Số");
                            
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("phải nhập đúng 8 ký tự trong mã ghi danh");
                    this.Focus();
                    return;
                }    
            }
        }
    }
}
