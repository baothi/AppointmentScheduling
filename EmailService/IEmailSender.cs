﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Mesage mesage);
        Task SendEmailAsync(Mesage mesage);
    }
}
