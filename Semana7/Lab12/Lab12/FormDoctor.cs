using Lab12.entities;
using Lab12.services;

namespace Lab12
{
    public partial class FormDoctor : Form
    {
        private DoctorService doctorService = new();

        public FormDoctor()
        {
            InitializeComponent();
            MostrarDoctores(doctorService.ListarTodo());
        }

        private void MostrarDoctores(List<Doctor> lista)
        {
            listViewDoctores.Items.Clear();
            foreach (Doctor doctor in lista)
            {
                ListViewItem fila = new(doctor.NroColegiatura);
                fila.SubItems.Add(doctor.NombreCompleto);
                fila.SubItems.Add(doctor.Especialidad);
                fila.SubItems.Add(doctor.AniosExperiencia.ToString());
                listViewDoctores.Items.Add(fila);
            }
        }

        private void LimpiarCampos()
        {
            tbEspecialidad.Text = "";
            tbNombreCompleto.Text = "";
            tbNroColegiatura.Text = "";
            nupAniosExperiencia.Value = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNroColegiatura.Text == "" || tbNombreCompleto.Text == "" || tbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación que el tbNroColegiatura sea un número
            if (!int.TryParse(tbNroColegiatura.Text, out _))
            {
                MessageBox.Show("Ingrese un Número de Colegiatura válido");
                return;
            }

            // Creación del objeto
            Doctor doctor = new()
            {
                NroColegiatura = tbNroColegiatura.Text,
                NombreCompleto = tbNombreCompleto.Text,
                Especialidad = tbEspecialidad.Text,
                AniosExperiencia = (int)nupAniosExperiencia.Value,
                // ¡Importante!
                Pacientes = new()
            };

            // Registro de doctor
            bool registrado = doctorService.Registrar(doctor);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un Número de Colegiatura diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarDoctores(doctorService.ListarTodo());
            // Limpiar campos
            LimpiarCampos();
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            if (listViewDoctores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione doctor");
                return;
            }

            String nroColegiatura = listViewDoctores.SelectedItems[0].Text;

            FormPaciente formPaciente = new(nroColegiatura);
            formPaciente.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new();
            formReporte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
