﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RateMyDebate.Models
{
    public class Message
    {
        [Key]
        public int messageId { get; set; }

        public UserInformation userInformationId { get; set; }
        
<<<<<<< HEAD
=======
        public virtual Inbox inboxId { get; set; }

>>>>>>> 78f4102d8cbf2acd24044589fa55063ef1913629
        public String  subject  { get; set; }

        public String messageText { get; set; }
    }
}