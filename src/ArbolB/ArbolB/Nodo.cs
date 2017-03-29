using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB
{
    public class Nodo
    {
        private String IDTransaccion, IDActivo, Participante, Compania, Depto, Date, Duracion;

        public Nodo(Random random)
        {
            IDTransaccion = GenerarID(random);
            IDActivo = String.Empty;
            Participante = String.Empty;
            Compania = String.Empty;
            Depto = String.Empty;
            Date = String.Empty;
            Duracion = String.Empty;
        }

        public Nodo(String IDActivo, String Participante, String Compania, String Depto, String Date, String Duracion, Random random)
        {
            IDTransaccion = GenerarID(random);
            this.IDActivo = IDActivo;
            this.Participante = Participante;
            this.Compania = Compania;
            this.Depto = Depto;
            this.Date = Date;
            this.Duracion = Duracion;
        }

        private String GenerarID(Random random)
        {
            String ID = String.Empty;
            int numero;
            while (ID.Length < 15)
            {
                numero = random.Next(47, 123);
                if ((48 <= numero && numero <= 57) || (65 <= numero && numero <= 90) || (97 <= numero && numero <= 122))
                {
                    ID += (char)numero;
                }
            }
            return ID;
        }

        public String ID
        {
            get
            {
                return IDTransaccion;
            }
        }

        public String Activo
        {
            get
            {
                return IDActivo;
            }
        }

        public String Usuario
        {
            get
            {
                return Participante;
            }
        }

        public String Empresa
        {
            get
            {
                return Compania;
            }
        }

        public String Departamento
        {
            get
            {
                return Depto;
            }
        }

        public String Fecha
        {
            get
            {
                return Date;
            }
        }

        public String Tiempo
        {
            get
            {
                return Duracion;
            }
        }

    }
}