using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6Benchmark;

public class PrintFileDetail
{
    public string NumeroRecibo { get; set; }
    public string NumeroVencimiento { get; set; }
    public DateTime FechaEmision { get; set; }
    public string Moneda { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public string MotivoDevolucion { get; set; }
    public string PeriodoFacturacion { get; set; }
    public string ImportePagadoRecibo { get; set; }
    public string ImportePendienteRecibo { get; set; }
    public DateTime FechaVencimientoConvenio { get; set; }
    public string ImporteRecibo { get; set; }
}