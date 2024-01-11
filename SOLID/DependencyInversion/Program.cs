// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

/*
 * Büyük sistem (bilgisayar), küçük sisteme (RAM) değil, küçük büyüğe bağlı olmalı.
 * 
 */
WhatsAppSender whatsappsender = new WhatsAppSender();
MailSender mailSender = new MailSender();
TelegramSender telegramSender = new TelegramSender();

Report report = new Report(whatsappsender);
report.Send("x");

Report report1 = new Report(mailSender);
report1.Send("y");

Report report2 = new Report(telegramSender);
report2.Send("z");
