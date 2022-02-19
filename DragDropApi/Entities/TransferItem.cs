﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DragDropApi.Entities
{
    [Table("TransferItem")]
    public class TransferItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int TransferItemId { get; set; }
        public string TransferTitle { get; set; }     
        public int TransferItemIndexId { get; set; }

    }
}
