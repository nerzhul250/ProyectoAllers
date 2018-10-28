﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.services;

namespace AllersProject
{
    public partial class Form1 : Form
    {
        private ServiceProvider model;
        public Form1()
        {
            InitializeComponent();
        }
        private double minS;
        private double minC;
        private void Form1_Load(object sender, EventArgs e)
        {
            customerPane1.main = this;
            menuPane1.main = this;
        }
        //METHODS
        public void initializeServiceProvider(String route)
        {
            try
            {
            ServiceProvider model1 = new ServiceProvider(route);
                model = model1;
            }catch(Exception e)
            {
                MessageBox.Show("Ruta no especificada");
            }
        }
        
        public void modifyGeneralPredictions(double minSup, double minConfidence)
        {
            minS = minSup;
            minC = minConfidence;
            List<Prediction> predictions = model.GetGeneralPredictions(minSup, minConfidence);
            double AverageRelevance = 0;
            double averageConfidence = 0;
            string text = "";
            foreach(var p in predictions)
            {
                averageConfidence += p.confidence;
                AverageRelevance += p.relevance;
                string antecedent = "If you buy these items:";
                string consequent = "You will probably buy those: ";
                for(int i = 0; i < p.antecedent.Length; i++)
                {
                    antecedent += ", " + p.antecedent[i].itemName;
                    consequent += ", " + p.consequent[i].itemName;
                }
                text+= antecedent+"\n"+consequent+"---------------------------------------\n";
            }
            averageConfidence /= predictions.Count;
            AverageRelevance /= predictions.Count;
            text = "Average relevance: " + AverageRelevance * 100 + "%" + "\n" + "Average confidence: " + averageConfidence + "%\n";
            customerPredictionPane1.setText(text);
        }
        //TODO
        public void modifyGroupOfCLients(String NoGroups)
        {
            int numberOfGroups = Int32.Parse(NoGroups);
        }
        public void predictionsByCostumer(String customerId)
        {
            if (model == null)
            {
                MessageBox.Show("En la primer pestaña debe ingresar los parámetros");
                return;
            }
            List<Prediction> predictions = model.GetPredictionsOfCustomer(customerId,minS,minC);
            double AverageRelevance = 0;
            double averageConfidence = 0;
            string text = "";
            foreach (var p in predictions)
            {
                averageConfidence += p.confidence;
                AverageRelevance += p.relevance;
                string antecedent = "If the client buy these items:";
                string consequent = "he will probably buy those: ";
                for (int i = 0; i < p.antecedent.Length; i++)
                {
                    antecedent += ", " + p.antecedent[i].itemName;
                    consequent += ", " + p.consequent[i].itemName;
                }
                text += antecedent + "\n" + consequent + "---------------------------------------\n";
            }
            averageConfidence /= predictions.Count;
            AverageRelevance /= predictions.Count;
            text = "Average relevance: " + AverageRelevance * 100 + "%" + "\n" + "Average confidence: " + averageConfidence + "%\n";
            customerPane1.modifyPredictions(text);
        }
        //END_METHODS

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerPane1_Load(object sender, EventArgs e)
        {

        }

        private void customerPane1_Load_1(object sender, EventArgs e)
        {

        }

        private void customerPane1_Load_2(object sender, EventArgs e)
        {

        }

        private void customerPredictionPane1_Load(object sender, EventArgs e)
        {

        }

        private void menuPane1_Load(object sender, EventArgs e)
        {

        }

        private void gruposClientes_Click(object sender, EventArgs e)
        {

        }

        private void customerPane1_Load_3(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }
    }
}
