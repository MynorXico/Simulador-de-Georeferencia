﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto2_SimuladorCiudades.Buildings
{
    class Restaurante:Edificio
    {
        // Declaración de atributos de la Clase
        private string _strTipoAlimento;
        private Image _imgImage = Properties.Resources.imgRestaurant;

        // Propiedades de la Clase
        public string strTipoAlimento
        {
            get
            {
                return _strTipoAlimento;
            }
            set
            {
                _strTipoAlimento = value;
            }
        }
        public Image imgImage
        {
            get
            {
                return _imgImage;
            }
            set
            {
                value = _imgImage;
            }
        }

        // Método constructor de la Clase
        public Restaurante(string unNombre, int unTipoAlimento, address unaDireccion)
        {
            strNombre = unNombre;
            #region Definir tipo de alimento
            switch (unTipoAlimento)
            {
                case 1:
                    strTipoAlimento = "Comida Rápida";
                    break;
                case 2:
                    strTipoAlimento = "Pizzería";
                    break;
                case 3:
                    strTipoAlimento = "Comida gourmet";
                    break;
            }
            #endregion
        }
    }
}
