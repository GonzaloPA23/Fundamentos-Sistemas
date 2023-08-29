using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA2
{
    public partial class Form1 : Form
    {
        // declaration of my variables
        Array registers = Array.CreateInstance(typeof(ModelRegister), 100); // array with 100 positions

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Button to add a new register to the array
            // Validation of the input data
            if(txtNameClient.Text == "" || txtNameFilm.Text == "" || cmbTypeFilm.Text == "" || cmbTypeService.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation correct data
            if(!(cmbTypeFilm.Text.Contains("accion") || cmbTypeFilm.Text.Contains("Accion") || cmbTypeFilm.Text.Contains("comedia") || cmbTypeFilm.Text.Contains("Comedia") ||
                cmbTypeFilm.Text.Contains("terror") || cmbTypeFilm.Text.Contains("Terror"))||!(cmbTypeService.Text.Contains("2D") || cmbTypeService.Text.Contains("2d") || cmbTypeService.Text.Contains("3d")
                || cmbTypeService.Text.Contains("3D") || cmbTypeService.Text.Contains("VIP") || cmbTypeService.Text.Contains("vip")))
            {
                MessageBox.Show("Debe ingresar datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Create object of the class ModelRegister
            ModelRegister register = new ModelRegister();
            register.NameClient = txtNameClient.Text;
            register.NameFilm = txtNameFilm.Text;
            register.TypeFilm = cmbTypeFilm.Text;
            register.TypeService = cmbTypeService.Text;

            switch (register.TypeService)
            {
                case "2D": case "2d":
                    register.MontoAPagar = 10.0;
                    break;
                case "3D": case "3d": 
                    register.MontoAPagar = 20.0;
                    break;
                case "VIP": case "vip":
                    register.MontoAPagar = 30.0;
                    break;
            }
            if (register.TypeFilm.Contains("comedia") || register.TypeFilm.Contains("Comedia")) register.MontoAPagar = register.MontoAPagar * 0.85; // 15% discount

            // Add the object to the array
            for(int i = 0; i < registers.Length; i++)
            {
                if(registers.GetValue(i) == null)
                {
                    registers.SetValue(register, i);
                    break;
                }
            }

            // Clean the form
            txtNameClient.Text = "";
            txtNameFilm.Text = "";
            cmbTypeFilm.Text = "";
            cmbTypeService.Text = "";
        }

        private void showRegisters()
        {
            listViewDatabase.Items.Clear();
            foreach(ModelRegister register in registers) // traverse the array
            {
                if(register != null)
                {
                    // Add the register to the listview
                    ListViewItem row = new ListViewItem(register.NameClient);
                    row.SubItems.Add(register.NameFilm);
                    row.SubItems.Add(register.TypeFilm);
                    row.SubItems.Add(register.TypeService);
                    row.SubItems.Add(register.MontoAPagar.ToString());
                    listViewDatabase.Items.Add(row);
                }
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            // Button to show the registers in the array
            showRegisters(); 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listViewDatabase.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String name = listViewDatabase.SelectedItems[0].Text;
            int pos = Array.IndexOf(registers, name);

            // Delete the register
            int count = 0;
            foreach (ModelRegister register in registers)
            {
                if (register == null) count++;
            }

            for (int i = 0; i < count; i++)
            {
                if(i >= pos)
                {
                    registers.SetValue(registers.GetValue(i + 1), i);
                }
            }

            showRegisters();
        }

        public class Metodo_Comparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                double MontoAPagar1 = ((ModelRegister)x).MontoAPagar;
                double MontoAPagar2 = ((ModelRegister)y).MontoAPagar;
                if (MontoAPagar1 < MontoAPagar2) return 1;
                else if (MontoAPagar1 > MontoAPagar2) return -1;
                else return 0;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ModelRegister register in registers)
            {
                if (register == null) count++;
            }
            Array.Sort(registers,0,registers.Length - count, new Metodo_Comparacion());
            showRegisters();
        }

        private void listViewDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
