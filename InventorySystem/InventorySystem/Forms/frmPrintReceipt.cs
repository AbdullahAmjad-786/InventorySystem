using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using InventorySystem.Forms;

namespace Inventory_System
{
    public partial class frmPrintReceipt : Form
    {
        private DataGridView grdCart;
        PrintDialog printDialog = new PrintDialog();
        private System.Windows.Forms.PrintPreviewDialog prnPreview =new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        PaperSize pkCustomSize1 = new PaperSize("First custom size", 540, 700);
        int temp = 0;
        bool IsItemsFinish;
        public frmPrintReceipt()
        {
            InitializeComponent();
  //          this.ActiveControl = button1;
            //   e.Graphics.DrawImage(memoryImage, 0, 0);

       

        }


        private void PrintReport()
        {
            try
            {
                printDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        public frmPrintReceipt(string name,string city,string state,DataGridView grdCart, string discount, string grandtotal, string cash, string due,string Invoice_Number,string balance,string customerNumber)
        {
            InitializeComponent();

            IsItemsFinish = false;
            printDocument.DefaultPageSettings.PaperSize = pkCustomSize1;

            lblDate.Text = "Date: " + System.DateTime.Now.ToString("MM/dd/yyyy");
            lblTime.Text = "Time: " + System.DateTime.Now.ToString("hh:mm:ss");
            lblVat.Text = Convert.ToDouble(discount).ToString();
            lblInvoice.Text = Invoice_Number;
            lblEmpName.Text = name;
            lblAddress.Text = state;
   
            lblNumber.Text = customerNumber;
            lblSubtotal.Text = Convert.ToDouble(grandtotal).ToString();
            lblTotal.Text = Convert.ToDouble(grandtotal).ToString();
            lblCash.Text = (Convert.ToDouble(cash)).ToString();
            lblChange.Text = Convert.ToDouble(due).ToString();
            lblBalance.Text = balance;
            this.grdCart = grdCart;
            if (grdCart != null)
            {
                int y = 0;
                foreach (DataGridViewRow row in grdCart.Rows)
                {
                    string itemName = row.Cells[1].Value.ToString();
                    string unitPrice = row.Cells[2].Value.ToString();

                    string qty = row.Cells[3].Value.ToString();
                    string unit = row.Cells[4].Value.ToString();
                    string total = row.Cells[5].Value.ToString();
                    dgw.Rows.Add(qty, itemName, unitPrice,unit, total);
                   // dgw.Height += 17;//19
                   // y += 17;
                }

               // Panel2.Location = new Point(9, 40 + y);//9,187,y
               // Panel1.Height += y;
               // this.Height += y;
              //  dgw.Height -= 15;//20
            }

            //Old Code
          // printDialog.Document = printDocument; //add the document to the dialog box... 
           // printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
         
            //New Code

        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void Panel1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // PrintReport();
            // Print Preview

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.


        }
        private void DisplayInvoice()
        {
            prnPreview.Document = this.printDocument;

            try
            {
                prnPreview.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }





        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int xpos = 20;
            int ypos = 10;
            int NFS = 10;
            int GHS = 12;
            e.Graphics.DrawString(lblTitle.Text.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(xpos + 150, ypos));
            e.Graphics.DrawString(lblDate.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(xpos + 30, ypos + 50));
            e.Graphics.DrawString(lblTime.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(xpos + 370, ypos + 50));
            e.Graphics.DrawString(Label4.Text.ToString(), new Font("Arial", NFS, FontStyle.Bold), Brushes.Black, new Point(xpos, ypos + 95));
            e.Graphics.DrawString(lblInvoice.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(xpos + 180, ypos + 95));
            
            e.Graphics.DrawString(Label6.Text.ToString(), new Font("Arial", NFS, FontStyle.Bold), Brushes.Black, new Point(20, 155));
            e.Graphics.DrawString(lblEmpName.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(200, 155));
           // e.Graphics.DrawString(label2.Text.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(500, 155));
           // e.Graphics.DrawString(lblNumber.Text.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(620, 155));
            e.Graphics.DrawString(label5.Text.ToString(), new Font("Arial", NFS, FontStyle.Bold), Brushes.Black, new Point(20, 205));
            e.Graphics.DrawString(lblAddress.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(200, 205));

            //if (!IsItemsFinish)
            //{
                e.Graphics.DrawString("ProductName", new Font("Arial", GHS, FontStyle.Bold), Brushes.Black, new Point(20, 250));
                e.Graphics.DrawString("Qty", new Font("Arial", GHS, FontStyle.Bold), Brushes.Black, new Point(240, 250));
                e.Graphics.DrawString("Price", new Font("Arial", GHS, FontStyle.Bold), Brushes.Black, new Point(290, 250));
                e.Graphics.DrawString("Unit", new Font("Arial", GHS, FontStyle.Bold), Brushes.Black, new Point(370, 250));
                e.Graphics.DrawString("Amount", new Font("Arial", GHS, FontStyle.Bold), Brushes.Black, new Point(460, 250));

            //}
                int numberOfRecord = 0;
                ypos = ypos + 285;
                for (int i = temp; i < dgw.RowCount; i++)
                {
                   if (numberOfRecord < 12)
                   {
                    e.Graphics.DrawString(dgw.Rows[i].Cells[1].Value.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(20, ypos));
                    e.Graphics.DrawString(dgw.Rows[i].Cells[0].Value.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(240, ypos));
                    e.Graphics.DrawString(dgw.Rows[i].Cells[2].Value.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(290, ypos));
                    e.Graphics.DrawString(dgw.Rows[i].Cells[3].Value.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(370, ypos));
                    e.Graphics.DrawString(dgw.Rows[i].Cells[4].Value.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(460, ypos));
                    ypos += 30;
                    numberOfRecord++;
                    if (i + 1 == dgw.RowCount)
                    {
                        IsItemsFinish = true;
                        temp = i + 1;
                    }
                   }
                   else
                   {

                    temp = i;
                    numberOfRecord = 0;
                    break;


                   }
            }

            if (!IsItemsFinish)
            {
                e.HasMorePages = true;
            }
            else
            {
                if (ypos + 120 <= 680)
                {
                   // e.Graphics.DrawString(subTotal.Text.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, ypos + 60));
                  //  e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(675, ypos + 60));
                    e.Graphics.DrawString(TotalAmount.Text.ToString(), new Font("Arial", NFS, FontStyle.Bold), Brushes.Black, new Point(20, ypos + 60));
                    e.Graphics.DrawString(lblTotal.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(460, ypos + 60));

                  /*  e.Graphics.DrawString(Cash.Text.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, ypos + 120));
                    e.Graphics.DrawString(lblCash.Text.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(675, ypos + 120));

                    e.Graphics.DrawString(change.Text.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, ypos + 150));
                    e.Graphics.DrawString(lblChange.Text.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(675, ypos + 150));

                    e.Graphics.DrawString(label7.Text.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, ypos + 180));
                    e.Graphics.DrawString(lblBalance.Text.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(675, ypos + 180));*/

                    e.Graphics.DrawString(lblLine.Text.ToString(), new Font("Arial", NFS, FontStyle.Regular), Brushes.Black, new Point(20, ypos + 90));

                    e.Graphics.DrawString(lblThank.Text.ToString(), new Font("Arial", NFS, FontStyle.Bold), Brushes.Black, new Point(230, ypos + 120));
                }
                else
                    e.HasMorePages = true;
            }
            //Previous Code
            // CaptureScreen();
            // e.Graphics.DrawImage(memoryImage, 170, 0);


        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void frmPrintReceipt_Load(object sender, EventArgs e)
        {
  
        }
      
        private void frmPrintReceipt_Shown_1(object sender, EventArgs e)
        {

            StartAsyncTimedWork();
        }






        private void StartAsyncTimedWork()
        {
            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                /* Not on UI thread, reenter there... */
                this.BeginInvoke(new EventHandler(timer1_Tick), sender, e);
            }
            else
            {
                lock (timer1)
                {
                    /* only work when this is no reentry while we are already working */
                    if (this.timer1.Enabled)
                    {
                        this.timer1.Stop();
                      //  this.DisplayInvoice();
                       
                      //  this.timer1.Start(); /* optionally restart for periodic work */
                    }
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
             lblTitle.Visible = false;
             textBox1.Enabled = true;
             lblTitle.SendToBack();
             textBox1.BringToFront();
             textBox1.Text = lblTitle.Text;
        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblTitle.BringToFront();
                lblTitle.Text = textBox1.Text;
                lblTitle.Visible = true;
                textBox1.SendToBack();
                textBox1.Enabled = false;
            }
        }

        private void lblEmpName_Click(object sender, EventArgs e)
        {
            lblEmpName.Visible = false;
            textBox2.Enabled = true;
            lblEmpName.SendToBack();
            textBox2.BringToFront();
            textBox2.Text = lblEmpName.Text;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblEmpName.BringToFront();
                lblEmpName.Text = textBox2.Text;
                lblEmpName.Visible = true;
                textBox2.SendToBack();
                textBox2.Enabled = false;
            }
        }


        private void lblNumber_Click(object sender, EventArgs e)
        {
            lblNumber.Visible = false;
            textBox4.Enabled = true;
            lblNumber.SendToBack();
            textBox4.BringToFront();
            textBox4.Text = lblNumber.Text;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblNumber.BringToFront();
                lblNumber.Text = textBox4.Text;
                lblNumber.Visible = true;
                textBox4.SendToBack();
                textBox4.Enabled = false;
            }
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            lblAddress.Visible = false;
            textBox3.Enabled = true;
            lblAddress.SendToBack();
            textBox3.BringToFront();
            textBox3.Text = lblAddress.Text;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblAddress.BringToFront();
                lblAddress.Text = textBox3.Text;
                lblAddress.Visible = true;
                textBox3.SendToBack();
                textBox3.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DisplayInvoice();
            // printDialog.Document = printDocument; //add the document to the dialog box... 
            // printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //OldCode
            //button1.Visible = false;
            //this.DisplayInvoice();

            //New Code
            SetReport();

        }

        private void Panel1_Click(object sender, EventArgs e)
        {
          //  if (button1.Visible == false)
            //    button1.Visible = true;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (button1.Visible == false)
                button1.Visible = true;
        }

        void SetReport()
        {
            frmPrintReport f1 = new frmPrintReport();
            f1.SetReportParameters(lblTitle.Text.ToString(),lblDate.Text.ToString(), lblTime.Text.ToString(), lblInvoice.Text.ToString(), lblEmpName.Text.ToString(), lblAddress.Text.ToString(), lblTotal.Text.ToString(),dgw);
            f1.Show();
        }
    }
}
