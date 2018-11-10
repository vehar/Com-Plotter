﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComPlotter
{
    class SettingsController : ISettingsController
    {
        public SettingsController()
        {
            m_serialController = new SerialController();
            Application.Current.Exit += new ExitEventHandler(Application_ApplicationExit);
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ConfigureSerial(string _serialName, string _baudrate, string _stopBits, string _parity)
        {
            m_serialController.Configure( _serialName, _baudrate, _stopBits, _parity );
        }

        public void ConnectToSerial()
        {
            try
            {
                m_serialController.Connect();
            }
            catch (InvalidOperationException _e)
            {
                MessageBox.Show("Error occured when trying to open Serial", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void DisconnectFromSerial()
        {
            m_serialController.Disconnect();
        }

        public void RefreshSerialState()
        {
            m_serialController.RefreshState();
        }

        public void Dispose()
        {
            m_serialController.Dispose();
        }

        public ISerialController SerialController { get { return m_serialController; } }

        ISerialController m_serialController;
    }
}
