﻿using System;

namespace PayToWrite.Application.DTO
{
    public class MessagesDTO
    {
        public long ID { get; set; }
        public long ChatID { get; set; }
        public string Text { get; set; }
        public DateTime CreationTime { get; set; }
        public string Autor { get; set; }
        
    }
}