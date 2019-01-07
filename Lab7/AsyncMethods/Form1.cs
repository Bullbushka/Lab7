using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6AsyncMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum ActivateType
        {
            End,
            IsComplete,
            Callback
        }

        private delegate string AsynchronousMethodDelegate(ActivateType source);

        private string AsynchronousMethod(ActivateType source)
        {
            string result = String.Empty;
            switch (source)
            {
                case ActivateType.Callback:
                    result = "Callback";
                    break;
                case ActivateType.End:
                    result = "End";
                    break;
                case ActivateType.IsComplete:
                    result = "Is Complete";
                    break;
            }
            return result;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            lblEnd.Text = AsynchronousMethod(ActivateType.End);
        }

        private void btnIsComplete_Click(object sender, EventArgs e)
        {
            lblIsComplete.Text = AsynchronousMethod(ActivateType.IsComplete);
        }

        private void btnCallback_Click(object sender, EventArgs e)
        {
            lblCallback.Text = AsynchronousMethod(ActivateType.Callback);
        }
    }
}
