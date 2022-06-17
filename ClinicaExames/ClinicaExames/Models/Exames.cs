using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaExames.Models
{
    public class Exames
    {
        public int Id { get; set; }

        public string cpf { get; set; }

        public string nome { get; set; }

        public string resultado { get; set; }


        public string dia { get; set; }

        public string hora { get; set; }


    }
}
