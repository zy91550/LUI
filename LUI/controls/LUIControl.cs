﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Runtime.CompilerServices;
using lasercom;

namespace LUI.controls
{
    public partial class LUIControl : UserControl
    {
        public Commander Commander { get; set; }
        protected BackgroundWorker worker;
        protected bool wait;

        public bool IsBusy
        {
            get
            {
                return worker.IsBusy;
            }
        }

        public ParentForm.State TaskBusy()
        {
            return ((ParentForm)FindForm()).TaskBusy;
        }

        #region dialogs

        protected void BlockingBlankDialog()
        {
            DialogResult result = MessageBox.Show("Please insert blank",
                "Blank",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                worker.CancelAsync();
            }
            wait = false;
        }

        protected void BlockingSampleDialog()
        {
            DialogResult result = MessageBox.Show("Please insert sample",
                    "Continue",
                    MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                worker.CancelAsync();
            }
            wait = false;
        }

        #endregion
    }
}
