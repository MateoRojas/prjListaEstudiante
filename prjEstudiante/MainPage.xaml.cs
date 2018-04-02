using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace prjEstudiante
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ICollection<clsEstudiante> students;

        public MainPage()
        {
            this.InitializeComponent();
            this.students = new List<clsEstudiante>();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            clsEstudiante student = new clsEstudiante();

            student.Nombre = txtName.Text;
            student.Apellido = txtSurname.Text;
            student.Calificacion = float.Parse(txtGrade.Text);
            student.Nacimiento = dtpBirth.Date.Date;

            students.Add(student);
            lsvStudents.Items.Add(student.Nombre + " " + student.Apellido + " " + student.Nacimiento.Day + "/" +  student.Nacimiento.Month + "/" + student.Nacimiento.Year);
        }
    }
}
