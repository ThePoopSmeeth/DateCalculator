using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            pkrStart.Format = DateTimePickerFormat.Custom;
            pkrStart.CustomFormat = "ddddd MMMMM, dd    hh:mm tt";
            pkrEnd.Format = DateTimePickerFormat.Custom;
            pkrEnd.CustomFormat = "ddddd MMMMM, dd    hh:mm tt";
            //pkrStart.ShowUpDown = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double TotalMinutesCalculated = Calculate_Difference(pkrStart.Value, pkrEnd.Value);
            TotalMinutesCalculated = Math.Round(TotalMinutesCalculated, 0);
            txtTotalMinutes.Text = TotalMinutesCalculated.ToString();
        }

        private double Calculate_Difference(DateTime Start, DateTime End)
        {
            var Span = End - Start;
            double differenceInMinutes = Span.TotalMinutes;
            return differenceInMinutes;
        }
    }
}
