﻿using Estructura;
using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
namespace AllersProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            DataManager data = new DataManager("../../../Datos/");
           
            
            
            
            
            
          

            //Debug.WriteLine("FP: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerFPGrowth fp = new AssociationAnalyzerFPGrowth(data, 0.005, 0.005);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    fp.frequentItemSets();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}

            //Debug.WriteLine("-----------------------------------------------------");
            //Debug.WriteLine("Brute Force 20");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerApriori bf20 = new AssociationAnalyzerApriori(data, 20, 0.005, 0.005, 5);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    bf20.GenerateFrequentItemSets();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}

            //Debug.WriteLine("-----------------------------------------------------");
            //Debug.WriteLine("Brute Force 25");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerApriori bf25 = new AssociationAnalyzerApriori(data, 25, 0.005, 0.005, 10);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    bf25.GenerateFrequentItemSets();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}

            //Debug.WriteLine("-----------------------------------------------------");
            //Debug.WriteLine("Brute Force 30");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerApriori bf30 = new AssociationAnalyzerApriori(data, 30, 0.005, 0.005, 15);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    bf30.GenerateFrequentItemSets();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}

            //Debug.WriteLine("-----------------------------------------------------");
            //Debug.WriteLine("Apiori 100");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerApriori ap100 = new AssociationAnalyzerApriori(data, 100, 0.005, 0.005, 5);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    ap100.GenerateFrequentItemSetsApriori();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}

            //Debug.WriteLine("-----------------------------------------------------");
            //Debug.WriteLine("Apiori 150");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerApriori ap150 = new AssociationAnalyzerApriori(data, 150, 0.005, 0.005, 10);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    ap150.GenerateFrequentItemSetsApriori();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}

            //Debug.WriteLine("-----------------------------------------------------");
            //Debug.WriteLine("Apiori 200");
            //for (int i = 0; i < 10; i++)
            //{
            //    AssociationAnalyzerApriori ap200 = new AssociationAnalyzerApriori(data, 200, 0.005, 0.005, 15);
            //    Stopwatch sw = Stopwatch.StartNew();
            //    ap200.GenerateFrequentItemSetsApriori();
            //    Debug.WriteLine(sw.ElapsedMilliseconds);
            //}


            //<<<<<<< HEAD
            //AssociationAnalyzerApriori aA = new AssociationAnalyzerApriori(data, 40, 0.05, 0.05, 3);
            //Debug.WriteLine("ItsBeenASuccesThereAre " + data.getTransactionsCount() + "Transactions!");
            //Debug.WriteLine(data.getCustomersCount() + "Customers!");
            //Debug.WriteLine(data.getItemsCount() + "Items!");
            //Debug.WriteLine(aA.getBinaryTransactions().Count + "binaryTransactions!");
            ////aA.GenerateFrequentItemSets();
            //Debug.WriteLine("EMPEZANDOApriori------------------------");
            //Stopwatch sw = Stopwatch.StartNew();
            //List<List<BigInteger>> list = aA.GenerateFrequentItemSetsApriori();
            //Debug.WriteLine("Numero de listas: " + list.Count);
            //int sum = 0;
            //foreach (List<BigInteger> lis in list)
            //{
            //    Debug.WriteLine("Conjuntos de items frecuentes con " + aA.CountSetBits(lis[0]) + " Items ");
            //    for (int i = 0; i < lis.Count(); i++)
            //    {
            //        String a = "";
            //        List<Item> items = aA.BinaryItemSetToObjectItemSet(lis[i]);
            //        for (int j = 0; j < items.Count(); j++)
            //        {
            //            a = a + "//" + items[j].itemName;
            //        }
            //        Debug.WriteLine(a);
            //    }
            //    sum += lis.Count();
            //}
            //Debug.WriteLine("Numero de conjuntos de items frecuentes: " + sum);
            //Debug.WriteLine("Tiempo de ejecucion en milisegundos " + sw.ElapsedMilliseconds);
            //sw.Stop();
            //            Debug.WriteLine("TERMINANDOApriori------------------------");

            //AssociationAnalyzerApriori aA = new AssociationAnalyzerApriori(data, 100, 0.01, 0.05, 63);
            //Debug.WriteLine("ItsBeenASuccesThereAre " + data.getTransactionsCount() + "Transactions!");
            //Debug.WriteLine(data.getCustomersCount() + "Customers!");
            //Debug.WriteLine(data.getItemsCount() + "Items!");
            //Debug.WriteLine(aA.getBinaryTransactions().Count + "binaryTransactions!");
            //Debug.WriteLine("EMPEZANDOApriori------------------------");
            //Stopwatch sw = Stopwatch.StartNew();
            //List<List<BigInteger>> list = aA.GenerateFrequentItemSetsApriori();
            //Debug.WriteLine("Numero de listas: " + list.Count);
            //int sum = 0;
            //foreach (List<BigInteger> lis in list)
            //{
            //    Debug.WriteLine("Conjuntos de items frecuentes con " + aA.CountSetBits(lis[0]) + " Items ");
            //    for (int i = 0; i < lis.Count(); i++)
            //    {
            //        String a = "";
            //        List<Item> items = aA.BinaryItemSetToObjectItemSet(lis[i]);
            //        for (int j = 0; j < items.Count(); j++)
            //        {
            //            a = a + "//" + items[j].itemName;
            //        }
            //        Debug.WriteLine(a);
            //    }
            //    sum += lis.Count();
            //}
            //Debug.WriteLine("Numero de conjuntos de items frecuentes: " + sum);
            //Debug.WriteLine("Tiempo de ejecucion en milisegundos " + sw.ElapsedMilliseconds);
            //            //Debug.WriteLine("REGLAS------------------>");
            //            //aA.AprioriRuleGeneration(list);
            //            //foreach (Tuple<BigInteger,BigInteger> rule in aA.rules)
            //            //{
            //            //    String a = "";
            //            //    List<Item> items = aA.BinaryItemSetToObjectItemSet(rule.Item1);
            //            //    for (int j = 0; j < items.Count(); j++)
            //            //    {
            //            //        a = a + "//" + items[j].itemName;
            //            //    }
            //            //    Debug.WriteLine(a+"---->");
            //            //    a = "";
            //            //    List<Item> items2 = aA.BinaryItemSetToObjectItemSet(rule.Item2);
            //            //    for (int j = 0; j < items2.Count(); j++)
            //            //    {
            //            //        a = a + "//" + items2[j].itemName;
            //            //    }
            //            //    Debug.WriteLine(a + "//");
            //            //}
            //            //sw.Stop();
            //            //Debug.WriteLine("TERMINANDOApriori------------------------");
            //>>>>>>> a924833252ab5600b68569554a0bd0ead1dcc40c
            //            //RARARARAR
            //            //Debug.WriteLine("EMPEZANDOBRUTE------------------------");
            //            //sw = Stopwatch.StartNew();
            //            //List<Item[]> items = aA.GenerateFrequentItemSets();
            //            //Debug.WriteLine("Numero de conjuntos de items frecuentes: " + items.Count);
            //            //Debug.WriteLine("Tiempo de ejecucion en milisegundos " + sw.ElapsedMilliseconds);
            //            //sw.Stop();
            //            //Debug.WriteLine("TERMINANDOBRUTE------------------------");


            //FPTree prueba;

            //List<List<string>> transacc = new List<List<string>>();
            //List<string> tranUniq = new List<string> { "b", "a", "c" };
            //transacc.Add(tranUniq);
            //List<string> tranUniq2 = new List<string> { "c", "a", "d" };
            //transacc.Add(tranUniq2);
            //List<string> tranUniq3 = new List<string> { "a", "d" };
            //transacc.Add(tranUniq3);
            //List<string> tranUniq4 = new List<string> { "c", "e" };
            //transacc.Add(tranUniq4);
            //List<string> tranUniq5 = new List<string> { "b", "f" };
            //transacc.Add(tranUniq5);
            //List<string> tranUniq6 = new List<string> { "d", "c" };
            //transacc.Add(tranUniq6);
            //prueba = new FPTree(transacc, 0.1);

            //List<List<string>> transacc = new List<List<string>>();
            //List<string> tranUniq = new List<string> { "b", "c", "a", "e"};
            //transacc.Add(tranUniq);
            //List<string> tranUniq2 = new List<string> { "c", "d"};
            //transacc.Add(tranUniq2);
            //List<string> tranUniq3 = new List<string> {"a", "c", "f", "b" };
            //transacc.Add(tranUniq3);
            //List<string> tranUniq4 = new List<string> { "c", "a", "b" };
            //transacc.Add(tranUniq4);
            //List<string> tranUniq5 = new List<string> { "f", "e", "d" };
            //transacc.Add(tranUniq5);
            //List<string> tranUniq6 = new List<string> { "a", "d", "c" };
            //transacc.Add(tranUniq6);
            //prueba = new FPTree(transacc, 0.5);

            //List<List<string>> list = prueba.FindFrequentItemsets();
            //foreach (List<string> list2 in list)
            //{
            //    Debug.WriteLine("AQUI");
            //    foreach (string x in list2)
            //    {
            //        Debug.Write(x + " ");
            //    }
            //}




        }




    }
}