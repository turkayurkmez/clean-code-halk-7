using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class MailService
    {
        public void SendInfoMail(string to)
        {
            MessageBox.Show($"{to} adresine mesaj iletildi");
        }
    }
}
