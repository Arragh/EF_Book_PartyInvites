using System;

namespace EF_Book_PartyInvites.Models
{
    public class GuestResponse
    {
        public Guid GuestResponseId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? WillAttend { get; set; }
    }
}
