using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gekko
{
    public partial class BossTextbox : UserControl
    {
        public BossTextbox()
        {
            InitializeComponent();
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, this.Text);
        }
        string placeHolderText = string.Empty;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [Description("Header Text of border displayed in the textbox"), Category("Data")]
        public string HeaderText
        {
            get { return xuiCustomGroupbox1.Text; }
            set { xuiCustomGroupbox1.Text = value; }
        }
        [Description("Fore color of text displayed in the textbox"), Category("Data")]
        public override Font Font
        {
            get => textBox1.Font; set => textBox1.Font = value;
        }
        public bool Multiline
        {
            get => textBox1.Multiline; set => textBox1.Multiline = value;
        }
        public Color HeaderLineColor
        {
            get => xuiCustomGroupbox1.BorderColor; set => xuiCustomGroupbox1.BorderColor = value;
        }
        public Color HeaderTextColor
        {
            get => xuiCustomGroupbox1.TextColor; set => xuiCustomGroupbox1.TextColor = value;
        }
   
    }
}
