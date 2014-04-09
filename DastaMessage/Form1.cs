using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;

namespace DastaMessage
{
    public partial class Form1 : Form
    {

        XDocument xDocument;
        FileStream streamDoc;

        XmlTextReader tr;
        List<string> valdaMessageData = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValdu_Click(object sender, EventArgs e)
        {
            
            XmlValidatingReader vr = new XmlValidatingReader(tr);

            //vr.Schemas.Add(null, "./dasta_XML_schemes/ds_cistype-4.01.01.xsd");
            //vr.Schemas.Add(null, "./dasta_XML_schemes/ds_dasta-4.02.04.xsd");
            //vr.Schemas.Add(null, "./dasta_XML_schemes/ds_ip.xsd");
            //vr.Schemas.Add(null, "./dasta_XML_schemes/ds_type-4.01.07.xsd");
            vr.ValidationType = ValidationType.Schema;
            vr.ValidationEventHandler += new ValidationEventHandler(ValidationHandler);

            while (vr.Read()) ;

            MessageBox.Show("Validation finished");
            lblVal.Text = "Validator error -> ";
            foreach (var err in valdaMessageData)
            {
                lblVal.Text+= err;
            }
        }

        public void ValidationHandler(object sender, ValidationEventArgs args)
        {
            valdaMessageData.Add("***Validation error"+"\tSeverity: " + args.Severity.ToString()+"\tMessage: " + args.Message);
        }

        private void btnReadZprava_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();

            OpenFileDialog openFileDialogNemoci = new OpenFileDialog();

            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;
            openFileDialogNemoci.Title = "Otevri Zpravu";
            if (openFileDialogNemoci.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //streamDoc = new FileStream(openFileDialogNemoci.FileName, FileMode.Open);
                    tr = new XmlTextReader(openFileDialogNemoci.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Pojebalo se to nekde pri nacitani \r\n Puvodni error: " + ex.Message);
                }
            }

            //try
            //{
            //    xDocument.Elements();
            //}
            //catch
            //{
            //    MessageBox.Show("Nenacetl si dokument");
            //    //throw new Exception("Nenacetl si dokument");
            //}



        }
        private string ListFileTerminalsOpen()
        {
            List<string> cteneTypySouboru = new List<string>();
            cteneTypySouboru.Add("XML files (*.xml)|*.xml");
            cteneTypySouboru.Add("All files (*.*)|*.*");

            string seznamCtenychSouboru = "";

            for (int i = 0; i < cteneTypySouboru.Count(); i++)
            {
                if (i < cteneTypySouboru.Count() - 1)
                { seznamCtenychSouboru += cteneTypySouboru[i] + "|"; }
                else
                { seznamCtenychSouboru += cteneTypySouboru[i]; }
            }

            return seznamCtenychSouboru;

        }
        private XDocument ReadDataFromXMLFile(string route)
        {
            return XDocument.Load(route);
        }
    }
}
