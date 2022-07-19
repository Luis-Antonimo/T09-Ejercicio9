using System;

namespace T09_Ejercicio9
{
    class Electrodomestico
    {
        //Atributos public para poder ser visibles por otras clases
        public double precioBase;
        public string color;
        public string consumoEnerg;
        public double peso;

        public Electrodomestico()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnerg = "F";
            peso = 5;
        }

        public Electrodomestico(double precioNew, double pesoNew)
        {
            precioBase = precioNew;
            peso = pesoNew;
            color = "blanco";
            consumoEnerg = "F";
            peso = 5;
        }

        public Electrodomestico(double precioNew, double pesoNew, string colorNew, string consumoEnergNew)
        {
            precioBase = precioNew;
            peso = pesoNew;
            color = colorNew;
            consumoEnerg = consumoEnergNew;
        }
    }
}