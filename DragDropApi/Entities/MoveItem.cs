using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DragDropApi.Entities
{
    [Table("MoveItem")]
    public class MoveItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int MoveItemId { get; set; }
        public string MoveTitle { get; set; }
        public int MoveItemIndexId { get; set; }
        public int Status { get; set; }
        [NotMapped]
        public int TransferItemId { get; set; }
        [NotMapped]
        public string TransferItemTitle { get; set; }
        [NotMapped]
        public int TransferItemIndexId { get; set; }

    }
}
