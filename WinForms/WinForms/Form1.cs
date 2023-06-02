namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Line 1
            button_Q.Click += button_Click;
            button_W.Click += button_Click;
            button_E.Click += button_Click;
            button_R.Click += button_Click;
            button_T.Click += button_Click;
            button_Y.Click += button_Click;
            button_U.Click += button_Click;
            button_I.Click += button_Click;
            button_O.Click += button_Click;
            button_P.Click += button_Click;
            button_clear.Click += button_Click;          // Without functionality

            // Line 2
            button_A.Click += button_Click;
            button_S.Click += button_Click;
            button_D.Click += button_Click;
            button_F.Click += button_Click;
            button_G.Click += button_Click;
            button_H.Click += button_Click;
            button_J.Click += button_Click;
            button_K.Click += button_Click;
            button_L.Click += button_Click;
            button_quotes.Click += button_Click;         //
            //button_Enter.Click += button_Click;          //
                                                       
            // Line 3
            button_UP1.Click += button_Click;            //
            button_Z.Click += button_Click;
            button_X.Click += button_Click;
            button_C.Click += button_Click;
            button_V.Click += button_Click;
            button_B.Click += button_Click;
            button_N.Click += button_Click;
            button_M.Click += button_Click;
            button_comma.Click += button_Click;          //
            button_dot.Click += button_Click;            //
            button_question.Click += button_Click; ;     //
            button_UP2.Click += button_Click;            //

            // Line 4
            button_symbol.Click += button_Click;         //
            button_Ctrl.Click += button_Click;           //
            button_smiley.Click += button_Click;         //
            button_space.Click += button_Click;          
            button_left.Click += button_Click;           //
            button_right.Click += button_Click;          //
            button_language.Click += button_Click;       //
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.TextBox.Text += clickedButton.Text;
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            this.TextBox.Text += "\n";
        }
    }
}