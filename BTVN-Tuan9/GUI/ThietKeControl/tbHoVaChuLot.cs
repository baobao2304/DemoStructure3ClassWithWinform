using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class tbHoVaChuLot:TextBox
    {

        public tbHoVaChuLot()
        {
            this.LostFocus += TbHoVaChuLot_LostFocus;
        }

        private void TbHoVaChuLot_LostFocus(object sender, EventArgs e)
        {
            if (this.Text != string.Empty)
            {
                if (!Regex.IsMatch(this.Text, @"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ ]+$"))
                {
                    MessageBox.Show("Họ và chữ lót nhập sai");
                }
            }
        }
    }
}
