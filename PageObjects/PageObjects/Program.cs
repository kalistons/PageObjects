using System;

namespace PageObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            BuscaCepPage buscaCepPage = new BuscaCepPage();

            buscaCepPage.VaParaTelaDeConsultaBuscaDoCep();

            buscaCepPage.InsiraOCep("74843420");

            buscaCepPage.BusqueOCep();
        }
    }
}
