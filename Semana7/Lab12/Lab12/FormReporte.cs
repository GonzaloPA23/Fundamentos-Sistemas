using Lab12.entities;
using Lab12.services;

namespace Lab12
{
    public partial class FormReporte : Form
    {
        private DoctorService doctorService = new();
        private PacienteService pacienteService = new();

        private void MostrarPacientes(List<Paciente> lista)
        {
            listViewPacientes.Items.Clear();
            foreach (Paciente paciente in lista)
            {
                ListViewItem fila = new(paciente.Dni);
                fila.SubItems.Add(paciente.NombreCompleto);
                fila.SubItems.Add(paciente.Edad.ToString());
                fila.SubItems.Add(paciente.FechaCita.ToString("dd/MM/yyyy"));
                listViewPacientes.Items.Add(fila);
            }
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
            lblCantidadDoctores.Text = lista.Count.ToString();
        }

        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnBuscarDoctoresConPacientesConMayorEdad_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConPacientesConMasEdad());
        }

        private void btnBuscarDoctoresConMenosPacientes_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConMenosPacientes());
        }

        private void btnBuscarPacientesPorEspecialidadDelDoctor_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese especialidad");
                return;
            }

            MostrarPacientes(pacienteService.ListarPacientesPorEspecialidadDoctor(tbEspecialidad.Text));
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarMenosIgualAniosExperienciaEspecificado_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConMenosAniosExperiencia((int)nupAniosExperiencia.Value));
        }

        private void btnOrdenarDeMayorAMenorSegunAniosExperiencia_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.OrdenarDoctoresDescendentePorAniosExperiencia());
        }

        private void LimpiarCampo()
        {
            txtBuscar.Text = "";
            cbBusqueda.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el campo a buscar");
                return;
            }
            switch (cbBusqueda.SelectedIndex)
            {
                case 0:
                    MostrarPacientes(pacienteService.ListarPacientesPorDni(txtBuscar.Text));
                    LimpiarCampo();
                    break;
                case 1:
                    MostrarPacientes(pacienteService.ListarPacientesPorNombreCompleto(txtBuscar.Text));
                    LimpiarCampo();
                    break;
                case 2:
                    switch (txtBuscar.Text)
                    {
                        case "enero":
                        case "Enero":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("January"));
                            break;
                        case "febrero":
                        case "Febrero":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("February"));
                            break;
                        case "marzo":
                        case "Marzo":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("March"));
                            break;
                        case "abril":
                        case "Abril":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("April"));
                            break;
                        case "mayo":
                        case "Mayo":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("May"));
                            break;
                        case "junio":
                        case "Junio":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("June"));
                            break;
                        case "julio":
                        case "Julio":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("July"));
                            break;
                        case "agosto":
                        case "Agosto":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("August"));
                            break;
                        case "septiembre":
                        case "Septiembre":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("September"));
                            break;
                        case "octubre":
                        case "Octubre":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("October"));
                            break;
                        case "noviembre":
                        case "Noviembre":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("November"));
                            break;
                        case "diciembre":
                        case "Diciembre":
                            MostrarPacientes(pacienteService.ListarPacientesPorMesFechaCita("December"));
                            break;
                        default:
                            MessageBox.Show("Ingrese un mes válido");
                            break;
                    }
                    LimpiarCampo();
                    break;
                default:
                    break;
            }
        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBusqueda.SelectedIndex) {
                case 0: // DNI
                    txtBuscar.PlaceholderText = "74923828";
                    break;
                case 1: // Nombre Completo
                    txtBuscar.PlaceholderText = "Juan o Juan Perez";
                    break;
                case 2: // Mes
                    txtBuscar.PlaceholderText = "febrero";
                    break;
                default:
                    txtBuscar.PlaceholderText = "";
                    break;
            }
        }
    }
}
