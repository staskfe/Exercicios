using System;

namespace Exercicios_API.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public string CodigoCompra { get; set; }
        public DateTime Data { get; set; }

    }
}
