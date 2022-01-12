using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace creacion_componentes_formulario_validacion.miscontroles
{
    /// <summary>
    /// Lógica de interacción para Control1.xaml
    /// </summary>
    public partial class Control1 : UserControl
    {
        public String tipo_validacion { get; set; }


        public Control1()
        {
            InitializeComponent();
            

        }
        public void validar() 
        {
            switch (tipo_validacion)
            {
                case "DNI":
                    if (tboxnew.Text == "")
                    {
                        labelerror.Content = "no puede estar vacio";
                    }
                    else if (tboxnew.Text.Length != 9 && tboxnew.Text != "")
                    {
                        labelerror.Content = "tienen que ser 8 numeros + un caracter";
                    }
                    else { labelerror.Content = ""; }

                    break;


                case "telefono":
                    if (tboxnew.Text == "")
                    {
                        labelerror.Content = "no puede estar vacio";
                    }
                    else if (tboxnew.Text.Length != 9 && tboxnew.Text != "")
                    {
                        labelerror.Content = "tienen que ser 9 numeros ";
                    }
                    else { labelerror.Content = ""; }
            
                    break;
            }
         
        }

        public void tboxnew_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tbox1 = sender as TextBox;
            validar();
        }

        
    }
}
