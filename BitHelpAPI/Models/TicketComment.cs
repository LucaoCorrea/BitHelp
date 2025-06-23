using System.ComponentModel.DataAnnotations;

namespace BitHelpAPI.Models
{
    public class TicketComment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }

        [Required]
        public TicketModel Ticket { get; set; }
        public int AuthorId { get; set; }

        [Required]
        public UserModel Author { get; set; }

        [Required]
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
