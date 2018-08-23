using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CudaUI
{
    public partial class MainForm : Form
    {
        [DllImport("CudaKernel.dll", EntryPoint = "AddVec")]
        private static extern bool AddVec(int[] c, int[] a, int[] b, int size);

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            int arraySize = 5;
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 10, 20, 30, 40, 50 };
            int[] c = new int[arraySize];

            bool result = AddVec(c, a, b, arraySize);

            tbOutput.Text = "";
            for (int i=0; i<arraySize; i++)
            {
                tbOutput.Text += c[i].ToString() + " ";
            }
        }
    }
}
