using BitHelpAPI.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace BitHelpAPI.Models
{
    public class TicketModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TicketStatus Status { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public int PriorityId { get; set; }

        public Priority priority { get; set; }

        public DateTime? CloseAt { get; set; }


        // UserModel with TicketModel relationship
        [Required]
        public int CreatedById { get; set; }

        public UserModel CreatedBy { get; set; }

        // tecnical response for the ticket
        public int? AssignedToId { get; set; }

        public UserModel? AssignedTo { get; set; }
    }
}
