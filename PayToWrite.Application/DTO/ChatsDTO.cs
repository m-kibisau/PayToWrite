﻿using System;

namespace PayToWrite.DTO.Application
{
    public class ChatsDTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
