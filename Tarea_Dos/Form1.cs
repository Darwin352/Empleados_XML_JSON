using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tarea_Dos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            string filePath = "datos.xml";
            dataSet1.ReadXml(filePath);
            DgEmpleados.DataSource = dataSet1;
            DgEmpleados.DataMember = "Empleado";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileJson = File.ReadAllText("datos.json");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            DgEmpleados.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
