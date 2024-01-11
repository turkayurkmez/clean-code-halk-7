using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{


    public interface ISender
    {
        void Send(string to);
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("whatsapp...");
        }
    }

    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("mail gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("telegram ile gönderildi");
        }
    }



    public class Report
    {

        private readonly ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }


        // public MailSender Sender { get; set; }
        public void Send(string to)
        {
            //MailSender sender = new MailSender();
            sender.Send(to);
        }
    }


}
