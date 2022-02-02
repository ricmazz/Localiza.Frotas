using System;
using System.Collections.Generic;
using System.Text;

namespace Localiza.Frotas.Infra.Facade
{
    public class DetranOptions
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string BaseUrl { get; set; }
        public string VistoriaUrl { get; set; }
        public int QuantidadeDiasParaAgendamento { get; set; }
    }
}
