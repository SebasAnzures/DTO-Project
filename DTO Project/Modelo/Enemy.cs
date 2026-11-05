using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Project.Modelo
{
    internal class Enemy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int ElementId { get; set; }
    }
}
