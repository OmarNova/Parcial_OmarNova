﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_OmarNova
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text=="Admin" && txtPassword.Password =="1234")
            {
                MainWindow login = (MainWindow)Window.GetWindow(this);
                login.frameMain.NavigationService.Navigate(new Administradora());
                
                
            }
            else if (txtUsername.Text == "Trabajadora" && txtPassword.Password == "5678")
            {
                MainWindow login = (MainWindow)Window.GetWindow(this);
                login.frameMain.NavigationService.Navigate(new Trabajadora());
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
       
   
    }


}
