using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class tbEmail : TextBox
    {
        public tbEmail()
        {
            this.LostFocus += TbEmail_LostFocus;
        }

        private void TbEmail_LostFocus(object sender, EventArgs e)
        {
            if(!IsValidEmail(this.Text))
            {
                MessageBox.Show("Email không hợp lệ");
            }
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
 (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            bool valid = false;
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(email);
            }
            return valid;
        }
    }
}
