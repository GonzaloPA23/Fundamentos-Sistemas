using Lab12.entities;

namespace Lab12.repositories
{
    internal class PacienteRepository
    {
        public PacienteRepository() { }

        public bool Existe(String Dni)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            foreach (Doctor doctor in doctores)
            {
                bool existe = doctor.Pacientes.Exists(paciente => paciente.Dni.Equals(Dni));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }

        public void Registrar(String nroColegiatura, Paciente paciente)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();

            // Buscar el doctor por el número de colegiatura
            Doctor? doctor = doctores.Find(doctor => doctor.NroColegiatura.Equals(nroColegiatura));
            if (doctor != null)
            {
                doctor.Pacientes.Add(paciente);
            }
        }

        public List<Paciente> ListarTodo(String nroColegiatura)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();

            // Buscar el doctor por el número de colegiatura
            Doctor? doctor = doctores.Find(doctor => doctor.NroColegiatura.Equals(nroColegiatura));
            if (doctor != null)
            {
                return doctor.Pacientes;
            }
            else
            {
                return new List<Paciente>();
            }
        }

        public List<Paciente> ListarPacientesPorEspecialidadDoctor(String especialidad) {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            List<Doctor> doctoresTemp = doctores.FindAll(doctor => doctor.Especialidad.Equals(especialidad));
            List<Paciente> pacientesTemp = new();

            // Recorre todos los pacientes por el especialidad del doctor
            foreach (Doctor doctor in doctoresTemp)
            {
                pacientesTemp.AddRange(doctor.Pacientes);
            }
            return pacientesTemp;
        }

        public List<Paciente> ListarPacientesPorDni(String dni)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            List<Paciente> pacientesTemp = new();

            foreach(Doctor doctor in doctores)
            {
                // Buscar el paciente por el dni
                Paciente? paciente = doctor.Pacientes.Find(paciente => paciente.Dni.Equals(dni));
                if (paciente != null)
                {
                    pacientesTemp.Add(paciente);
                }
            }
            return pacientesTemp;
        }

        public List<Paciente> ListarPacientesPorNombreCompleto(String nombreCompleto)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            List<Paciente> pacientesTemp = new();

            foreach (Doctor doctor in doctores)
            {
                // Buscar el paciente por el nombre completo
                List<Paciente> pacientes = doctor.Pacientes.FindAll(paciente => paciente.NombreCompleto.Contains(nombreCompleto));
                pacientesTemp.AddRange(pacientes);
            }
            return pacientesTemp;
        }

        // Buscar por el mes de la fecha de cita del paciente en texto por ejemplo (agosto o Agosto)
        public List<Paciente> ListarPacientesPorMesFechaCita(String mes)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            List<Paciente> pacientesTemp = new();

            foreach (Doctor doctor in doctores)
            {
                // Buscar el paciente por el mes de la fecha de cita
                List<Paciente> pacientes = doctor.Pacientes.FindAll(paciente => paciente.FechaCita.ToString("MMMM").Equals(mes));
                pacientesTemp.AddRange(pacientes);
            }
            return pacientesTemp;
        }
        
    }
}
