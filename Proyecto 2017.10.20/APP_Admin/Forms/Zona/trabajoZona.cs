using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APP_Admin;
using Logica;
using Entidades;

namespace APP_Admin
{
    internal class trabajoZona
    {
        public static string IDDepartamento(string dpto)
        {
            string IdDepto = string.Empty;
            switch (dpto)
            {
                case "Canelones":
                    IdDepto = "A";
                    break;
                case "Maldonado":
                    IdDepto = "B";
                    break;
                case "Rocha":
                    IdDepto = "C";
                    break;
                case "Treinta y Tres":
                    IdDepto = "D";
                    break;
                case "Cerro Largo":
                    IdDepto = "E";
                    break;
                case "Rivera":
                    IdDepto = "F";
                    break;
                case "Artigas":
                    IdDepto = "G";
                    break;
                case "Salto":
                    IdDepto = "H";
                    break;
                case "Paysandú":
                    IdDepto = "I";
                    break;
                case "Río Negro":
                    IdDepto = "J";
                    break;
                case "Soriano":
                    IdDepto = "K";
                    break;
                case "Colonia":
                    IdDepto = "L";
                    break;
                case "San José":
                    IdDepto = "M";
                    break;
                case "Flores":
                    IdDepto = "N";
                    break;
                case "Florida":
                    IdDepto = "O";
                    break;
                case "Lavalleja":
                    IdDepto = "P";
                    break;
                case "Durazno":
                    IdDepto = "Q";
                    break;
                case "Tacuarembó":
                    IdDepto = "R";
                    break;
                case "Montevideo":
                    IdDepto = "S";
                    break;
                default:
                    IdDepto = string.Empty;
                    break;
            }
            return IdDepto;
        }

        public static string NombreDepartamento(string id)
        {
            string departamento;
            switch (id)
            {
                case "A":
                    departamento = "Canelones";
                    break;
                case "B":
                    departamento = "Maldonado";
                    break;
                case "C":
                    departamento = "Rocha";
                    break;
                case "D":
                    departamento = "Treinta y Tres";
                    break;
                case "E":
                    departamento = "Cerro Largo";
                    break;
                case "F":
                    departamento = "Rivera";
                    break;
                case "G":
                    departamento = "Artigas";
                    break;
                case "H":
                    departamento = "Salto";
                    break;
                case "I":
                    departamento = "Paysandú";
                    break;
                case "J":
                    departamento = "Río Negro";
                    break;
                case "K":
                    departamento = "Soriano";
                    break;
                case "L":
                    departamento = "Colonia";
                    break;
                case "M":
                    departamento = "San José";
                    break;
                case "N":
                    departamento = "Flores";
                    break;
                case "O":
                    departamento = "Florida";
                    break;
                case "P":
                    departamento = "Lavalleja";
                    break;
                case "Q":
                    departamento = "Durazno";
                    break;
                case "R":
                    departamento = "Tacuarembó";
                    break;
                case "S":
                    departamento = "Montevideo";
                    break;
                default:
                    departamento = string.Empty;
                    break;
            }
            return departamento; 
        }

    }
}
