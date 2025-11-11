using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VentasCapas.Entities
{
    internal class Cliente
    {
        private Int16 idCliente;

        public short IdCliente 
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private string entidad;

        public string Entidad
        {
            get { return entidad; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El valor de entidad no puede estar vacío.");
                else if (value.Length > 100)
                    throw new ArgumentException("El valor de entidad no puede exceder los 100 caracteres.");
                entidad = value; 
            }
        }

        private string ruc;

        public string Ruc
        {
            get { return ruc; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El valor de RUC no puede estar vacío.");
                //else if (value.Length > 11)
                //    throw new ArgumentException("El valor de RUC no puede exceder los 11 caracteres.");
                //if (!Validator.isRuc(value))
                else if (!Regex.IsMatch(value, @"^\d{1,11}$"))
                    throw new ArgumentException("El RUC debe contener solo dígitos y como máximo 11 caracteres.");
                ruc = value; 
            }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set 
            {
                if (value.Length > 100)
                    throw new ArgumentException("El valor de dirección no puede exceder los 100 caracteres.");
                direccion = value; 
            }
        }

        private string contacto;

        public string Contacto
        {
            get { return contacto; }
            set 
            {
                if (value.Length > 50)
                    throw new ArgumentException("El valor de contacto no puede exceder los 50 caracteres.");
                contacto = value; 
            }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set 
            {
                if (value.Length > 50)
                    throw new ArgumentException("El valor de correo no puede exceder los 50 caracteres.");
                correo = value; 
            }
        }

        private string area;

        public string Area
        {
            get { return area; }
            set 
            {
                if (value.Length > 50)
                    throw new ArgumentException("El valor de area no puede exceder los 50 caracteres.");
                area = value; 
            }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set 
            {
                if (value.Length > 20)
                    throw new ArgumentException("El valor de telefono no puede exceder los 20 caracteres.");
                telefono = value; 
            }
        }

        private string observacion;

        public string Observacion
        {
            get { return observacion; }
            set 
            {
                if (value.Length > 100)
                    throw new ArgumentException("El valor de observación no puede exceder los 100 caracteres.");
                observacion = value; 
            }
        }

        private string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set 
            {
                if (value.Length > 20)
                    throw new ArgumentException("El valor de ciudad no puede exceder los 20 caracteres.");
                ciudad = value; 
            }
        }

        private List<Venta> ventas;

        public List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }
    }
}
