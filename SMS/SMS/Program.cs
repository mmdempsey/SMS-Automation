using System;
using Twilio;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;



namespace SMS
{
    class Program
    {

        static void Main(string[] args)
        {
            string sid = Properties.Settings.Default.sid;
            string token = Properties.Settings.Default.token;
            string YOUR_PHONE = Properties.Settings.Default.YOUR_PHONE;
            string YOUR_TWILIO_NUM = Properties.Settings.Default.YOUR_TWILIO_NUM;
            TwilioClient.Init(sid, token);
            MessageResource.Create(
                from: new PhoneNumber("YOUR_TWILIO_NUM"), 
                to: new PhoneNumber("YOUR_PHONE"), 
                body: $"Please let this work.");
         }
    }
}
