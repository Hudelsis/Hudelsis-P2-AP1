using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hudelsis_P2_AP1.Entidades
{
    public class ProyectosDetalle
    {
       [Key]
        public int ProyectosDetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TareaId { get; set; }
        public string Requerimiento { get; set; }
        public double Tiempo { get; set; }


        [ForeignKey("TareaId")]
        public Tareas tareas { get; set; } = new Tareas();
    }
}

