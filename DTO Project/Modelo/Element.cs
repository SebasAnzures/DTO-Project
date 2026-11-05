using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Project.Modelo
{
    internal class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AdvantageId { get; set; }
        public int ResistanceId { get; set; }
        public int NullId { get; set; }
    }
}
