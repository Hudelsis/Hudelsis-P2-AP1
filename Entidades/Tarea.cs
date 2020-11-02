using System.ComponentModel.DataAnnotations;


namespace Hudelsis_P2_AP1.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public string TipoTarea { get; set; }
    }
}