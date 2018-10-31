﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AllersProject
{
    public partial class MenuPane : UserControl
    {
        public Form1 main;
        private FrmPrgBarr frmPrgBar;

        public MenuPane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                button1.Text = folderBrowserDialog1.SelectedPath;
                toolTip1.SetToolTip(this.button1,button1.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                try
                {
                    frmPrgBar = new FrmPrgBarr();
                    frmPrgBar.StartPosition = FormStartPosition.CenterParent;
                    backgroundWorker1.RunWorkerAsync();
                    frmPrgBar.ShowDialog(main);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(1);
            main.initializeServiceProvider(button1.Text);
            worker.ReportProgress(2);
            main.modifyGeneralPredictions(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text));
            worker.ReportProgress(3);
            main.modifyGroupOfCLients(textBox3.Text);
            worker.ReportProgress(4);
            main.getRelevantCustomers();
            //It might Be useful
            //if (worker.CancellationPending == true)
            //{
            //    e.Cancel = true;
            //    break;
            //}
        }
        //  This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    frmPrgBar.SetLabelText("Cargando datos");
                    frmPrgBar.SetProgressBarValue(25);
                    break;
                case 2:
                    frmPrgBar.SetLabelText("Generando predicciones generales");
                    frmPrgBar.SetProgressBarValue(50);
                    break;
                case 3:
                    frmPrgBar.SetLabelText("Agrupando clientes similares");
                    frmPrgBar.SetProgressBarValue(75);
                    break;
                case 4:
                    frmPrgBar.SetLabelText("Generando predicciones por cliente");
                    frmPrgBar.SetProgressBarValue(100);
                    break;
                default:
                    break;
            }
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                label5.Text = "Cancelado!";
                label5.ForeColor = Color.Red;
                frmPrgBar.Close();
            }
            else if (e.Error != null)
            {
                label5.Text = "Error";
                MessageBox.Show(e.Error.Message);
                label5.ForeColor = Color.Red;
                frmPrgBar.Close();
            }
            else
            {
                label5.Text = "Estado de la aplicacion: Con datos";
                label5.ForeColor = Color.Green;
                frmPrgBar.Close();
            }
        }
        
    }
}
