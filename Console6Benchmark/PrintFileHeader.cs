using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6Benchmark;

public class PrintFileHeader
{
    /* 1 */
    public string TipoRegistro { get; set; }
    /* 2 */
    public string Idioma { get; set; }
    /* 3 */
    public string IdNotification { get; set; }
    /* 4 */
    public string SistemaOrigen { get; set; }
    /* 5 */
    public string FechaProcesado { get; set; }
    /* 6 */
    public string NoPlantillaCarta { get; set; }
    /* 7 */
    public string NoPlantillaCartaApremio { get; set; }
    /* 8 */
    public string PosibilidadCombinacion { get; set; }
    /* 9 */
    public string Logo { get; set; }
    /* 10 */
    public string DireccionEmpresa { get; set; }
    /* 11 */
    public string CodigoPostal { get; set; }
    /* 12 */
    public string Municipio { get; set; }
    /* 13 */
    public string Provincia { get; set; }
    /* 14 */
    public string Cabecera { get; set; }
    /* 15 */
    public string Telefono { get; set; }
    /* 16 */
    public string TelefonoAveria { get; set; }
    /* 17 */
    public string TelefonoAtencion { get; set; }
    /* 18 */
    public string DatosRegistralesEmpresa1 { get; set; }
    /* 19 */
    public string HorarioCobros { get; set; }
    /* 20 */
    public string HorarioAtencionPublico { get; set; }
    /* 21 */
    public string Fax { get; set; }
    /* 22 */
    public string NombreEmpresa { get; set; }
    /* 23 */
    public string DescripcionContrata { get; set; }
    /* 24 */
    public string NombreDestinatario { get; set; }
    /* 25 */
    public string DireccionDestinatario { get; set; }
    /* 26 */
    public string DistritoBarrioDestinatario { get; set; }
    /* 27 */
    public string CódigoPostalDestinatario { get; set; }
    /* 28 */
    public string PoblacionDestinatario { get; set; }
    /* 29 */
    public string ProvinciaDestinatario { get; set; }
    /* 30 */
    public string PaisDestinatario { get; set; }
    /* 31 */
    public string NombreSuministro { get; set; }
    /* 32 */
    public string NoIdentificaciónSuministro { get; set; }
    /* 33 */
    public string DireccionSuministro { get; set; }
    /* 34 */
    public string CodigoPostalSuministro { get; set; }
    /* 35 */
    public string PoblacionSuministro { get; set; }
    /* 36 */
    public string ProvinciaSuministro { get; set; }
    /* 37 */
    public string NoClienteContrato { get; set; }
    /* 38 */
    public string NumeroContrato { get; set; }
    /* 39 */
    public DateTime FechaLimitePago { get; set; }
    /* 40 */
    public string FechaSuspensionSuministro { get; set; }
    /* 41 */
    public string ImporteDeuda { get; set; }
    /* 42 */
    public string ImporteGastosReconexion { get; set; }
    /* 43 */
    public string DetalleDeuda { get; set; }
    /* 44 */
    public string Conceptos { get; set; }
    /* 45 */
    public string TotalPrincipal { get; set; }
    /* 46 */
    public string PorcentajeRecargoSegundaVelocidad { get; set; }
    /* 47 */
    public string Recargo { get; set; }
    /* 48 */
    public string TotalPagarCartaApremio { get; set; }
    /* 49 */
    public string CodigoBanco { get; set; }
    /* 50 */
    public string DescripcionBanco { get; set; }
    /* 51 */
    public string CodigoSucursal { get; set; }
    /* 52 */
    public string DescripcionSucursal { get; set; }
    /* 53 */
    public string DigitoCuenta { get; set; }
    /* 54 */
    public string NumeroCuenta { get; set; }
    /* 55 */
    public string FechaVencimiento { get; set; }
    /* 56 */
    public string OficinaPago { get; set; }
    /* 57 */
    public string CodigoBarras { get; set; }
    /* 58 */
    public string FechaCargo { get; set; }
    /* 59 */
    public string Emisora { get; set; }
    /* 60 */
    public string ReferenciaCobro { get; set; }
    /* 61 */
    public DateTime Identificador { get; set; }
    /* 62 */
    public string ImporteDocumentoFormato { get; set; }
    /* 63 */
    public string NumeroDocumento { get; set; }
    /* 64 */
    public DateTime FechaExpedicion { get; set; }
    /* 65 */
    public string ImporteDocumento { get; set; }
    /* 66 */
    public string Moneda { get; set; }
    /* 67 */
    public DateTime FechaEnvio { get; set; }
    /* 68 */
    public string TextoLibre { get; set; }
    /* 69 */
    public string CodigoBarrasReparto { get; set; }
    /* 70 */
    public string NoSecuencial { get; set; }
    /* 71 */
    public string OficinaCorreos { get; set; }
    /* 72 */
    public string ClaseEnvio { get; set; }
    /* 73 */
    public string Aclaraciones { get; set; }
    /* 74 */
    public string TextoBD { get; set; }
    /* 75 */
    public string LugarCobro { get; set; }
    /* 76 */
    public string CuentaBancariaContrata { get; set; }
    /* 77 */
    public string DireccionWeb { get; set; }
    /* 78 */
    public string PaisIBAN { get; set; }
    /* 79 */
    public string CodigoIBAN { get; set; }
    /* 80 */
    public string NoCampana { get; set; }
    /* 81 */
    public string VersionDescarga { get; set; }
    /* 82 */
    public string DatosRegistralesEmpresa2 { get; set; }
    /* 83 */
    public string DescripcionCampana { get; set; }
    /* 84 */
    public string PorcentajeRecargoTerceraVelocidad { get; set; }
    /* 85 */
    public string Periodo { get; set; }
    /* 86 */
    public string CodigoCliente { get; set; }
    /* 87 */
    public string CodelineCodigoCliente { get; set; }
    /* 88 */
    public string CodelineImporte { get; set; }
    /* 89 */
    public string CodelineCuentaPosta { get; set; }
    /* 90 */
    public string Codeline896 { get; set; }
    /* 91 */
    public string FechaAutorizacionPosta { get; set; }
    /* 92 */
    public string CampoLibre1Carta { get; set; }
    /* 93 */
    public string CampoLibre2Carta { get; set; }
    /* 94 */
    public string CampoLibre3Carta { get; set; }
    /* 95 */
    public string ServiciosActivos { get; set; }
    /* 96 */
    public string TipologiaUso { get; set; }
    /* 97 */
    public string Plantilla { get; set; }
    /* 98 */
    public string CampoLibre4Carta { get; set; }
    /* 99 */
    public string CampoLibre5Carta { get; set; }
    /* 100 */
    public string PobrezaActiva { get; set; }
    /* 101 */
    public string TextoServiciosSociales { get; set; }
    /* 102 */
    public string ImpVtoConvenio { get; set; }
    /* 103 */
    public string ImpTotalConvenio { get; set; }
    /* 104 */
    public string MonedaCartaPagoN57 { get; set; }
    /* 105 */
    public string CPR { get; set; }
    /* 106 */
    public string PeriodoPago { get; set; }
    /* 107 */
    public string CampoLibre1 { get; set; }
    /* 108 */
    public string CampoLibre2 { get; set; }
    /* 200 */
    public string EnviadoSicer { get; set; }
    /* 201 */
    public string FechaEnvioSicer { get; set; }
    /* 202 */
    public string RecepcionClienteSicer { get; set; }
    /* 203 */
    public string FechaRecepcionClienteSicer { get; set; }
    /* 204 */
    public string CodigoEnvio { get; set; }
    /* 205 */
    public string CodigoPruebaElectronica { get; set; }
    /* 206 */
    public string RafagaSicer { get; set; }
    /* 207 */
    public string ErrorSicer { get; set; }
    public string IdExplotacion { get; set; }
    public string Explotacion { get; set; }
    public string CanalEnvio { get; set; }
    public string CodigoInstalacion { get; set; }
    public string Servicio { get; set; }
    public string Contrata { get; set; }
    public List<PrintFileDetail> PrintingProviderDetails { get; set; }
}