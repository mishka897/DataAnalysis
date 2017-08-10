using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace DataAnalysis
{
    public partial class DataAnalysisPage : ContentPage
    {
        public DataAnalysisPage()
        {
            InitializeComponent();
		}

        protected override void OnAppearing()
        {
            //lädt xml document als variable
			var document = XDocument.Load("/Users/mishka/Projects/DataAnalysis/DataAnalysis/File.xml");
            //erstellt zeile <Result> als variable
			var row = document.Descendants("Result").FirstOrDefault();
            //var element = document.Element("Lieferdienst");
			if (row != null)
			{
                //erstellt Zeile <Lieferdienst> als variable
				var ld = row.Element("Lieferdienst")?.Value;
                LieferdienstLabel1.Text = "Lieferdienst: " + ld;
                var s = row.Element("Service")?.Value;
                ServiceLabel1.Text = "Service: " + s;
				var j = row.Element("Jahr")?.Value;
				var m = row.Element("Monat")?.Value;
				var t = row.Element("Tag")?.Value;
				DateLabel1.Text = "Datum: "+ t + "/" + m + "/" + j;
				var a = row.Element("Anzahl")?.Value;
				AnzahlLabel1.Text = "Anzahl: " + a;
				var c = row.Element("Customer")?.Value;
				CustomerLabel1.Text = "Customer: " + c;
				var k = row.Element("Kanton")?.Value;
				KantonLabel1.Text = "Kanton: " + k;
    
			}
        }
    }
}

