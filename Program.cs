using System;

namespace T09_Ejercicio9
{
    class Electrodomestico
    {
        //No sé a qué se refiere con "Indica que se podrán heredar"
        private double precioBase;
        private string color;
        private string consumoEnerg;
        private double peso;

        //No se a qué se refiere con declara constantes en el constructor
        //por defecto
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