using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new SmtpClient("0.0.0.0", 27);
            var message = new MailMessage("william.chenta@gmail.com", "william.chenta@edu.sc.senai.br");
            message.Subject = "teste email c#";
            message.Body = "teste email c#";
            cliente.Send(message);
        }
    }
}
