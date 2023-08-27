using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Create un enum con los tipos de servicios que se pueden realizar en el autolavado (Lavado, Encerado, Silicona)

namespace Ejercicio_Arreglos
{
    public partial class Form1 : Form
    {
        private frmTablaServicios frmTablaServicios;
        public Form1()
        {
            InitializeComponent();
            frmTablaServicios = new frmTablaServicios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModelRegister modelRegister = new ModelRegister();
            modelRegister.Name = txtNameClient.Text;
            modelRegister.TypeCar = cmbTypeCar.Text;
            modelRegister.TypeService = cmbTypeService.Text;

            switch (modelRegister.TypeService)
            {
                case "Lavado": case "1": case "Lavado (1)":
                    modelRegister.MontoAPagar = 10.00; break;
                case "Encerado": case "2": case "Encerado (2)":
                    modelRegister.MontoAPagar = 15.00; break;
                case "Silicona": case "3": case "Silicona (3)":
                    modelRegister.MontoAPagar = 10.00; break;
            }

            if (modelRegister.TypeCar.Contains("Camioneta"))
            {
                modelRegister.MontoAPagar = modelRegister.MontoAPagar * 1.05;
            }

            ListViewItem row = new ListViewItem(modelRegister.Name);
            row.SubItems.Add(modelRegister.TypeCar);
            row.SubItems.Add(modelRegister.TypeService);
            row.SubItems.Add(modelRegister.MontoAPagar.ToString());
            frmTablaServicios.listView.Items.Add(row);

        }

        private void button1_Click(object sender, EventArgs e)
        {       
            frmTablaServicios.Show();
        }

    }
}
