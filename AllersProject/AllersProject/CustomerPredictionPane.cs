﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllersProject
{
    public partial class CustomerPredictionPane : UserControl
    {
        public Form1 main { get; set; }

        public char tipoPanel { get; set; }

        public string customerId { get; set; }

        public double minConf { get; set; }

        public double minSup { get; set; }

        public CustomerPredictionPane()
        {
            InitializeComponent();
        }

        private void CustomerPredictionPane_Load(object sender, EventArgs e)
        {

        }
        delegate void SetTextCallback(string text);
        public void setText(String text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.dataGridView1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                dataGridView1.Rows.Clear();
                string[] predictions = text.Split('\n');
                int num = (predictions.Length - 2) / 7;
                for (int i = 0; i < num; i++)
                {
                    int pos = i * 7 + 2;
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells["Pre"].Value = predictions[pos++];
                    row.Cells["Pos"].Value = predictions[pos++];
                    row.Cells["Relevancia"].Value = predictions[pos++];
                    row.Cells["Confiabilidad"].Value = predictions[pos++];
                    row.Cells["GananciaMinimaAdicional"].Value = predictions[pos++];
                    row.Cells["GananciaMaximaAdicional"].Value = predictions[pos++];
                }
            }
        }

        public string getSpecificCodes()
        {
            return textCodigosProductos.Text;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoPanel == Form1.PESTANHA_PRED)
            {
                try
                {
                    main.modifyGeneralPredictions(main.minSGeneral, main.minCGeneral, true,"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (tipoPanel == Form1.PESTANHA_CLIENTE)
            {
                try
                {
                    main.predictionsByCostumer(customerId, minSup, minConf, true,"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoPanel == Form1.PESTANHA_PRED)
            {
                try
                {
                    main.modifyGeneralPredictions(main.minSGeneral, main.minCGeneral, false, comboBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if (tipoPanel == Form1.PESTANHA_CLIENTE)
            {
                try
                {
                    main.predictionsByCostumer(customerId, minSup, minConf, false,comboBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
