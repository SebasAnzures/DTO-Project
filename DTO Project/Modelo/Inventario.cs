using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Project.Modelo
{
    internal class Inventario
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int CharacterId { get; set; }
    }
}
