using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects
{
    public class BuscaCepPage : PageObjectsBase
    {
      
        private readonly string urlBuscaCep = "http://www.buscacep.correios.com.br/sistemas/buscacep/";
        private readonly string tagNameInputCep = "relaxation";
        private readonly string tagNameBtnBusca = "btn2";
        private const int Firefox = 1;
        private const int Chrome = 2;

        public BuscaCepPage(): base(Chrome)
        {
            
        }

        public void VaParaTelaDeConsultaBuscaDoCep()
        {
            NavegueParaPagina(urlBuscaCep, 2);
        }

        public void InsiraOCep(string cep)
        {
            PreenchaOCampoPorTag(By.Name(tagNameInputCep), cep);
        }

        public void BusqueOCep()
        {
            ClickNoElementoDeTag(By.ClassName(tagNameBtnBusca));
        }
    }
}
