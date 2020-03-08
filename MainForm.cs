using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Algorithms
{
    public partial class MainForm : Form
    {
        AlgorithmsClass algorithmsClass = new AlgorithmsClass();
        public MainForm()
        {
            InitializeComponent();
            cbMethods.Items.Add("Сортировка выбором");
            cbMethods.Items.Add("Сортировка вставками");
            cbMethods.Items.Add("Сортировка перестановками");
            cbMethods.Items.Add("Сортировка быстрая");
        }

        
        private void cbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbOutput.Clear();
                tbTime.Clear();
                string Item = (string)cbMethods.SelectedItem;
                int n;                                                                          //размер массива
                String[] inputDate = tbInput.Text.Split(';');                                   //запись в вх. чисел в массив
                n = inputDate.Length;                                                           //определение размера массива
                double[] inputArray = new double[n];
                for (int i = 0; i < n; i++)
                {
                    inputArray[i] = double.Parse(inputDate[i]);

                }
                algorithmsClass.CopyArray(inputArray);
                    switch (Item)
                    {
                        case "Сортировка выбором":
                            algorithmsClass.Selection_sort();
                            break;
                        case "Сортировка вставками":
                            algorithmsClass.Insertion_sort();
                            break;
                        case "Сортировка перестановками":
                            algorithmsClass.bubble_sort();
                            break;
                        case "Сортировка быстрая":
                            algorithmsClass.quicksort(0, n - 1);
                            break;
                        default:
                            break;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        tbOutput.AppendText(algorithmsClass.SortedArray[i].ToString() + "; ");
                    }
                    tbTime.AppendText(algorithmsClass.Time.ToString());
                }
            catch {
                    tbOutput.AppendText("Ошибка при вводе массива");
                }

            


        }
    }
}
