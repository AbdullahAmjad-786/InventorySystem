using Inventory_System;
using InventorySystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventorySystem
{
    public partial class MainForm : Form
    {
        string txtBarCode;
        int _qunatity=0;
        bool visi=false;
        double _grandtotal;
        PointOfSale pos;
        int checkInt;
        bool flag = true;
        DateTime date;
        double checkDouble;
        double _grand=0;
        DataTable dt;
        private void MainForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            // TODO: This line of code loads data into the 'inventoryDataSet.product' table. You can move, or remove it, as needed.

           // dataGridView1.DataSource = pos.getDataPOS().Tables[0];

            this.ActiveControl = textBarCode;
            date = DateTime.Now;
            txtInvoiceDate.Text = date.Date.ToString("MM-dd-yyyy");
            txtInvoiceNo.Text = pos.getInvoiceID().ToString();
            //     txtCustomerId.Text = pos.getCustumerID().ToString();

        }
        public MainForm()
        {
            date = new DateTime();
            pos = new PointOfSale();
            InitializeComponent();



        }

        public void LoadData(DataGridView Data)
        {
            dataGridView1.Columns.Add("barcode", "BarCode");
            dataGridView1.Columns.Add("productname", "ProductName");
            dataGridView1.Columns.Add("sellingprice", "SellingPrice");
            dataGridView1.Columns.Add("Qty", "Quantity");
            dataGridView1.Columns.Add("unit", "Unit");

            for (int i=0;i<Data.Rows.Count;i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Data.Rows[i].Cells[0].Value;
                dataGridView1.Rows[i].Cells[1].Value = Data.Rows[i].Cells[2].Value;
                dataGridView1.Rows[i].Cells[2].Value = Data.Rows[i].Cells[5].Value;
                dataGridView1.Rows[i].Cells[3].Value = Data.Rows[i].Cells[6].Value;
                dataGridView1.Rows[i].Cells[4].Value = Data.Rows[i].Cells[7].Value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            if (textBarCode.Text != "")
            {
                Stock stock = new Stock();
                DataRow row = stock.getCurrent(textBarCode.Text);
                txtAvailableQty.Text = row["qtytotal"].ToString();
                txtUnitPrice.Text = row["sellingprice"].ToString();
            }
        }



        private void txtTotal_calculate(object sender, EventArgs e)
        {
            if (txtSaleQty.Text!="" && txtUnitPrice.Text!="")
            {
                int saleQty = Convert.ToInt32(txtSaleQty.Text);
                //MessageBox.Show(txtUnitPrice.Text);
                double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
                double total = saleQty * unitPrice;
                txtTotalAmount.Text = total.ToString();
            }

        }





        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text == "" || !int.TryParse(txtInvoiceNo.Text, out checkInt) || Convert.ToInt32(txtInvoiceNo.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Invoice number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtInvoiceDate.Text == "")
            {
                MessageBox.Show("Please Enter Invoice Date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtCustomerId.Text == "" || !int.TryParse(txtCustomerId.Text, out checkInt) || Convert.ToInt32(txtCustomerId.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Customer Id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Please Enter Item Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtUnitPrice.Text == "" || !double.TryParse(txtUnitPrice.Text, out checkDouble) || Convert.ToInt32(txtUnitPrice.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Selling Price", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtAvailableQty.Text == "" || !int.TryParse(txtAvailableQty.Text, out checkInt) || Convert.ToInt32(txtAvailableQty.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Available Quntity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtSaleQty.Text == "" || !int.TryParse(txtSaleQty.Text, out checkInt) || Convert.ToInt32(txtSaleQty.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Sale Quntity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
            else if (txtDiscount.Text == "" || !int.TryParse(txtDiscount.Text, out checkInt) || Convert.ToInt32(txtDiscount.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Discount Rate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtInvoiceNo.Focus();
            }
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
           //  this.Close();
           // Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        // Add cart button
        private void button9_Click(object sender, EventArgs e)
        {  //if (!txtAvailableQty.Text.ToString().Equals("0"))
                {

                    addToCart();
                }
             //   else {
               //     MessageBox.Show("Sorry Quantity not available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                //}
            
        }
        // Add to cart funtion
        private void addToCart()
        {
            //  MessageBox.Show(txtAvailableQty.Text);


            if (textBarCode.Text == "")
            {
                

            }
            else
            { }
              

                if (txtItemName.Text != "" && txtUnitPrice.Text != "" && txtSaleQty.Text != "")
                {

                double _total = Convert.ToInt32(txtSaleQty.Text) * Convert.ToDouble(txtUnitPrice.Text);
                    _grandtotal += _total;

                    lblGrandTotal.Text = _grandtotal.ToString();
                     txtGrandTotal.Text = _grandtotal.ToString();
         //       txtGrandTotal.Text = (Convert.ToDouble(txtGrandTotal.Text) + _grandtotal- _grand).ToString();


                if (textBarCode.Text == "")
                {
                   // string r = pos.getQty(Convert.ToInt32(txtSearchByItemCode.Text));
                    //pos.updateQtyForPos(txtSearchByItemCode.Text,Convert.ToInt32(r)-1);
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = pos.getDataPOS().Tables[0];


                    string[] row = { txtSearchByItemCode.Text, txtItemName.Text, txtUnitPrice.Text, txtSaleQty.Text,textUnit.Text, _total.ToString() };
                    grdCart.Rows.Add(row);
                    clearInvoiceTextBox();

                }
                else
                {
                    

                    string[] row = { textBarCode.Text, txtItemName.Text, txtUnitPrice.Text, txtSaleQty.Text, textUnit.Text, _total.ToString() };
                    grdCart.Rows.Add(row);
                    clearInvoiceTextBox();


                }

            }
                else
                { //MessageBox.Show("There is nothing to add in the cart, Please Add ITEMS ");
            }
        }
        private void clearInvoiceTextBox()
        {
            txtItemName.Text = "";
            txtSaleQty.Text = "1";
            txtUnitPrice.Text = "";
            //txtTotalAmount.Text = "";
            txtAvailableQty.Text = "";
            txtSearchByItemCode.Text = "";
            textUnit.Text = "";
            this.ActiveControl = textBarCode;
        }

    // button remove item 
        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.grdCart.SelectedRows)
            {
                string b = Convert.ToString(item.Cells["TotalPrice"].Value);
                string a = Convert.ToString(item.Cells["Qty"].Value);
                string barcode = Convert.ToString(item.Cells["BarCode"].Value);

                //int qtyDB = Convert.ToInt32(pos.getQty(barcode));

                // pos.updateQtyForPos(barcode.ToString(), (qtyDB + Convert.ToInt32(a)));

                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Cells[0].Value.ToString().Equals(barcode.ToString()))
                    {
                        row1.Cells[3].Value = (Convert.ToInt32(row1.Cells[3].Value.ToString()) + Convert.ToInt32(a)).ToString();
                        if (row1.Cells[3].Value.ToString().Equals("0"))
                        {
                            visi = true;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                            currencyManager1.SuspendBinding();
                            row1.Visible = false;
                            currencyManager1.ResumeBinding();
                        }
                       else if (visi)
                        {
                            visi = false;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                            currencyManager1.SuspendBinding();
                            row1.Visible = true;
                            currencyManager1.ResumeBinding();

                        }

                        dataGridView1.Refresh();
                        break;
                    }
                }


               // dataGridView1.DataSource = null;
               // dataGridView1.DataSource = pos.getDataPOS().Tables[0];





                grdCart.Rows.RemoveAt(item.Index);
                _grandtotal -= Convert.ToDouble(b);
                lblGrandTotal.Text = _grandtotal.ToString();
                txtGrandTotal.Text = _grandtotal.ToString();


            }


        }

        // button remove ALL
        private void button11_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdCart.Rows)
            {

                if (grdCart.Columns[3].Name == "Qty")
                {

                    string a = Convert.ToString(row.Cells["Qty"].Value);
                    int barcode = Convert.ToInt32(row.Cells["BarCode"].Value);

                  //  int qtyDB = Convert.ToInt32(pos.getQty(barcode));

                  //  pos.updateQtyForPos(barcode.ToString(), (qtyDB + Convert.ToInt32(a)));

                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        if (row1.Cells[0].Value.ToString().Equals(barcode.ToString()))
                        {
                            row1.Cells[3].Value = (Convert.ToInt32(row1.Cells[3].Value.ToString()) + Convert.ToInt32(a)).ToString();
                            if (row1.Cells[3].Value.ToString().Equals("0"))
                            {
                                visi = true;
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                                currencyManager1.SuspendBinding();
                                row1.Visible = false;
                                currencyManager1.ResumeBinding();
                            }
                           else if (visi)
                            {
                                visi = false;
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                                currencyManager1.SuspendBinding();
                                row1.Visible = true;
                                currencyManager1.ResumeBinding();

                            }

                            break;
                        }
                    }


                }
            }
            dataGridView1.Refresh();

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = pos.getDataPOS().Tables[0];

            grdCart.Rows.Clear();
            grdCart.Refresh();
            _grandtotal = 0;
            txtGrandTotal.Text = "0";
            lblGrandTotal.Text = "";

        }








        private void grdCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           if (grdCart.Columns[e.ColumnIndex].Name == "Qty" )
            {

                int selectedrowindex = grdCart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grdCart.Rows[selectedrowindex];


                    //your code goes here



                    string a = Convert.ToString(selectedRow.Cells["Qty"].Value);
                    string b = Convert.ToString(selectedRow.Cells["sellingprice"].Value);
                    string c = Convert.ToString(selectedRow.Cells["TotalPrice"].Value);
                    string d = Convert.ToString(selectedRow.Cells["BarCode"].Value);

                    string barcode = Convert.ToString(selectedRow.Cells["BarCode"].Value);



                   int qtyDB = Convert.ToInt32(pos.getQty(barcode));
                int resultentqty=0;
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Cells[0].Value.ToString().Equals(barcode.ToString()))
                    {
                        resultentqty = Convert.ToInt32(row1.Cells[3].Value.ToString());

                        break;
                    }
                }
//==============================================================



                int new_qty = Convert.ToInt32(a); // NEW VALUE OF QUANTITY

//                    Product p = new Product();
                // int resultentqty = p.totalQty(barcode.ToString(), "0");
                
                if (resultentqty < new_qty || new_qty < 0)
                    {
                    //    selectedRow.Cells["Qty"].Value = qtyDB.ToString();
                    //pos.updateQtyForPos(barcode.ToString(),qtyDB- qtyDB);
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = pos.getDataPOS().Tables[0];
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        if (row1.Cells[0].Value.ToString().Equals(barcode.ToString()))
                        {
                            selectedRow.Cells["Qty"].Value = row1.Cells[3].Value.ToString();
                            row1.Cells[3].Value = (Convert.ToInt32(row1.Cells[3].Value.ToString()) - Convert.ToInt32(row1.Cells[3].Value.ToString())).ToString();
                         /*   if (row1.Cells[3].Value.ToString().Equals("0"))
                            {
                                visi = true;
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                                currencyManager1.SuspendBinding();
                                row1.Visible = false;
                                currencyManager1.ResumeBinding();
                            }
                           else if (visi)
                            {
                                visi = false;
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                                currencyManager1.SuspendBinding();
                                row1.Visible = true;
                                currencyManager1.ResumeBinding();

                            }
                            */
                            dataGridView1.Refresh();
                            break;
                        }
                    }
                    selectedRow.Cells["Qty"].Value = new_qty;
                    _grandtotal = _grandtotal - Convert.ToDouble(c);




                    double changed_total = Convert.ToInt32(a) * Convert.ToDouble(b);

                    selectedRow.Cells["TotalPrice"].Value = changed_total.ToString();
                    _grandtotal += changed_total;
                    lblGrandTotal.Text = _grandtotal.ToString();
                    txtGrandTotal.Text = _grandtotal.ToString();

                    //MessageBox.Show("Sorry Quantity not available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    }
                    else
                    {
                        //pos.updateQtyForPos(barcode.ToString(), (qtyDB - Convert.ToInt32(a)));
                       // dataGridView1.DataSource = null;
                       // dataGridView1.DataSource = pos.getDataPOS().Tables[0];
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        if (row1.Cells[0].Value.ToString().Equals(barcode.ToString()))
                        {
                            row1.Cells[3].Value = (Convert.ToInt32(row1.Cells[3].Value.ToString()) - Convert.ToInt32(a)).ToString() ;
                           /* if (row1.Cells[3].Value.ToString().Equals("0"))
                            {
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                                visi = true;
                                currencyManager1.SuspendBinding();
                                row1.Visible = false;
                                currencyManager1.ResumeBinding();
                            }
                            else if (visi)
                            {
                                visi = false;
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                                currencyManager1.SuspendBinding();
                                row1.Visible = true;
                                currencyManager1.ResumeBinding();

                            }*/

                            dataGridView1.Refresh();
                            break;
                        }
                    }


                    _grandtotal = _grandtotal - Convert.ToDouble(c);




                        double changed_total = Convert.ToInt32(a) * Convert.ToDouble(b);

                        selectedRow.Cells["TotalPrice"].Value = changed_total.ToString();
                        _grandtotal += changed_total;
                        lblGrandTotal.Text = _grandtotal.ToString();
                        txtGrandTotal.Text = _grandtotal.ToString();
                    }


            }

            else if (grdCart.Columns[e.ColumnIndex].Name == "sellingprice")
            {
                int selectedrowindex = grdCart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grdCart.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Qty"].Value);
                string b = Convert.ToString(selectedRow.Cells["sellingprice"].Value);
                string c = Convert.ToString(selectedRow.Cells["TotalPrice"].Value);


                _grandtotal = _grandtotal - Convert.ToDouble(c);




                double changed_total = Convert.ToInt32(a) * Convert.ToDouble(b);

                selectedRow.Cells["TotalPrice"].Value = changed_total.ToString();
                _grandtotal += changed_total;
                lblGrandTotal.Text = _grandtotal.ToString();
                txtGrandTotal.Text = _grandtotal.ToString();
            }
        }


        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "" || !int.TryParse(txtDiscount.Text, out checkInt) || Convert.ToInt32(txtDiscount.Text) <= 0) 
            {
                double discount = Convert.ToDouble(txtDiscount.Text);
                if (discount > 0)
                {
                    discount = (discount / 100) * _grandtotal;
                    _grandtotal -= discount;
                }
                else
                    _grandtotal -= discount;

      //          txtGrandTotal.Text = _grandtotal.ToString();
                lblGrandTotal.Text = _grandtotal.ToString();
            }
            else
            {
                txtDiscount.Text = "0";
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
             if (!(txtDiscount.Text == "" || !int.TryParse(txtDiscount.Text, out checkInt) || Convert.ToInt32(txtDiscount.Text) <= 0)) 
            {
                double discount = Convert.ToDouble(txtDiscount.Text);
               /* if (discount > 0)
                {
                    discount = (discount / 100) * _grandtotal;
                    _grandtotal -= discount;
                }
                else*/
                    _grandtotal -= discount;

                txtGrandTotal.Text = _grandtotal.ToString();
                lblGrandTotal.Text = _grandtotal.ToString();
            }
            else
            {
                txtDiscount.Text = "0";
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["productno"].Value);
            string b = Convert.ToString(selectedRow.Cells["productname"].Value);
            string c = Convert.ToString(selectedRow.Cells["sellingprice"].Value);

            txtBarCode = pos.getBarCode(Convert.ToInt32(a)).ToString();
            txtItemName.Text = b;
            txtUnitPrice.Text = c;


        }
       
        private void txtSearchByItemName_TextChanged(object sender, EventArgs e)
        {
           /* string searchValue = txtSearchByItemName.Text;

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName + ", System.String) like '" + txtSearchByItemName.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            */
            if(txtSearchByItemName.Text == "")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
        }

        private static Regex _gtinRegex = new System.Text.RegularExpressions.Regex("^(\\d{8}|\\d{12,14})$");

        public static bool IsValidGtin(string code)
        {
            if (!(_gtinRegex.IsMatch(code))) return false; // check if all digits and with 8, 12, 13 or 14 digits
            code = code.PadLeft(14, '0'); // stuff zeros at start to garantee 14 digits
            int[] mult = Enumerable.Range(0, 13).Select(i => ((int)(code[i] - '0')) * ((i % 2 == 0) ? 3 : 1)).ToArray(); // STEP 1: without check digit, "Multiply value of each position" by 3 or 1
            int sum = mult.Sum(); // STEP 2: "Add results together to create sum"
            return (10 - (sum % 10)) % 10 == int.Parse(code[13].ToString()); // STEP 3 Equivalent to "Subtract the sum from the nearest equal or higher multiple of ten = CHECK DIGIT"
        }

        private void txtSearchByItemCode_TextChanged(object sender, EventArgs e)
        {

          if(txtSearchByItemCode.Text == "")
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
          
           
               /* BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[0].DataPropertyName + ", System.String) like '" + txtSearchByItemCode.Text.Replace("'", "''") + "%'");
                dataGridView1.DataSource = bs;
                dataGridView1.Refresh();*/
            

        }



        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" || txtCustomerId.Text != "")
            {
                string cname="";
                if (txtCustomerName.Text == "")
                {
                    cname = "ABC";
                    txtCustomerName.Text="";
                }
                string date1 = DateTime.Now.ToString("MM-dd-yyyy");

                if(txtCustomerId.Text != "")
                    pos.addProduct(txtInvoiceNo.Text, txtCustomerId.Text, txtCustomerName.Text, _grandtotal.ToString(), date1);
                else
                    pos.addProduct(txtInvoiceNo.Text, "-1", txtCustomerName.Text, _grandtotal.ToString(), date1);


                foreach (DataGridViewRow row in grdCart.Rows)
                {
                    string itemName = row.Cells[1].Value.ToString();

                    string price = row.Cells[2].Value.ToString();

                    string qty = row.Cells[3].Value.ToString();

                    string barCode = row.Cells[0].Value.ToString();

                    if(txtCustomerId.Text != "")
                        pos.addSales(txtCustomerId.Text, itemName,price, txtInvoiceNo.Text, qty);
                    else
                        pos.addSales("-1", itemName,price, txtInvoiceNo.Text, qty);
                    pos.updateQty(barCode,(Convert.ToInt32(qty)));
                    // prdt.(barCode, "0");
                }


                Customer c = new Customer();
                if (txtCustomerId.Text != "")
                {
                    if (!c.checkContactNumber(Convert.ToInt64(txtCustomerId.Text)))
                    {
                        if (c.SetBalance(Convert.ToInt64(txtCustomerId.Text), txtNewBalance.Text))
                        {
                        //    MessageBox.Show("Customer Balance is Succefully Added");
                        }
                        else
                        {

                        }
                    }

                }

               

                frmPrintReceipt print = new frmPrintReceipt(txtCustomerName.Text,customerCity,customerState,grdCart, txtDiscount.Text, lblGrandTotal.Text, txtTotal.Text, txtPaymentDue.Text,txtInvoiceNo.Text,txtNewBalance.Text,txtCustomerId.Text);
                print.ShowDialog();
                clearInvoiceTextBox();
                clearAll();
                txtInvoiceNo.Text = pos.getInvoiceID().ToString();
                //dataGridView1.DataSource = null;
                //dataGridView1.DataSource = pos.getDataPOS().Tables[0];

                this.ActiveControl = textBarCode;
            }
            else 
            {
                
                MessageBox.Show("Please INSERT CUSTOMER ID OR CUSTOMER NAME FIRST", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }





        }

        public void clearAll()
        {
            txtGrandTotal.Text = "";
            txtDiscount.Text = "0";
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerName.ReadOnly = false;
            txtPaymentDue.Text = "0";
            button5.Enabled = true;
            txtTotalAmount.Text = "";
            txtTotal.Text = "0";
            txtSearchByItemName.Text = "";
            grdCart.Rows.Clear();
            grdCart.Refresh();
            _grandtotal = 0;
            txtGrandTotal.Text = "0";
            lblGrandTotal.Text = "";
            txtNewBalance.Text = "0";
            txtBalnace.Text = "0";
            this.ActiveControl = textBarCode;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["barcode"].Value);
            string b = Convert.ToString(selectedRow.Cells["productname"].Value);
            string c = Convert.ToString(selectedRow.Cells["sellingprice"].Value);

            txtBarCode = pos.getBarCode(Convert.ToInt32(a)).ToString();
            txtItemName.Text = b;
            txtUnitPrice.Text = c;

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string a = row.Cells[0].Value.ToString();
                string b = row.Cells[1].Value.ToString();
                string c = row.Cells[2].Value.ToString();




                txtAvailableQty.Text = row.Cells[3].Value.ToString();
                if (txtAvailableQty.Text == "0")
                    txtSaleQty.Text = "0";

                textUnit.Text = row.Cells[4].Value.ToString();
                if (!row.Cells[3].Value.ToString().Equals("0"))
                {
                    row.Cells[3].Value = (Convert.ToInt32(row.Cells[3].Value.ToString()) - 1).ToString();
                }
                    /*if (row.Cells[3].Value.ToString().Equals("0"))
                    {
                        visi = true;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else if (visi)
                    {
                        visi = false;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                        currencyManager1.SuspendBinding();
                        row.Visible = true;
                        currencyManager1.ResumeBinding();

                    }*/
                    dataGridView1.Refresh();
                    
                
            
            txtSearchByItemCode.Text = a;
            txtItemName.Text = b;
            // textBarCode.Text = txtSearchByItemCode.Text;
            txtUnitPrice.Text = c;
        }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            

            dataGridView1.Columns["barcode"].HeaderText = "BarCode";
           dataGridView1.Columns["productname"].HeaderText = "Prodcut Name";
            dataGridView1.Columns["sellingprice"].HeaderText = "Selling Price";
            dataGridView1.Columns["Qty"].HeaderText = "Quantity";
            
        }

        private void txtSearchByItemCode_Leave(object sender, EventArgs e)
        {

        }

        private void txtSearchByItemCode_Enter(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
            clearInvoiceTextBox();
            this.ActiveControl = textBarCode;
        }

        private void txtAvailableQty_TextChanged(object sender, EventArgs e)
        {
            int qunatity = 0;
            if (txtAvailableQty.Text != "0")
            {

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void grdCart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                   }

        private void textBarCode_Leave(object sender, EventArgs e)
        {
            if (pos.validBarCode(textBarCode.Text))
            {

                Stock stock = new Stock();
                DataRow row = stock.getCurrent(textBarCode.Text);
                double total = Convert.ToDouble(row["totalqty"].ToString()); 
                txtAvailableQty.Text = total.ToString();
                txtUnitPrice.Text = row["sellingprice"].ToString();
                txtItemName.Text = pos.getItemName(textBarCode.Text);
                //txtItemName.Text = row["productname"].ToString();

                if (txtSaleQty.Text != "")
                {
                   int saleQty = Convert.ToInt32(txtSaleQty.Text);
                    double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    double _total = saleQty * unitPrice;
                    txtTotalAmount.Text = _total.ToString();
                    addToCart();
                    textBarCode.Text = "";
                    this.ActiveControl = textBarCode;
                }
                else
                    MessageBox.Show("Kindly specify quantity first ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else {

               // MessageBox.Show("Sorry invalid Barcode, Try Again");
            }

        }

        private void textBarCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBarCode_Leave_1(object sender, EventArgs e)
        {
            if (pos.validBarCodeAnd(textBarCode.Text))
            {
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Cells[0].Value.ToString().Equals(textBarCode.Text) && row1.Visible == true)
                    {
                        if(!row1.Cells[3].Value.ToString().Equals("0"))
                        row1.Cells[3].Value = (Convert.ToInt32(row1.Cells[3].Value.ToString()) - 1).ToString();
                        txtAvailableQty.Text = row1.Cells[3].Value.ToString();
                        if (row1.Cells[3].Value.ToString().Equals("0"))
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            visi = true;
                            currencyManager1.SuspendBinding();
                            row1.Visible = false;
                            currencyManager1.ResumeBinding();
                        }
                        else if (visi)
                        {
                            visi = false;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                            currencyManager1.SuspendBinding();
                            row1.Visible = true;
                            currencyManager1.ResumeBinding();

                        }

                        dataGridView1.Refresh();
                        break;
                    }
                }

                if (!txtAvailableQty.Text.ToString().Equals(""))
                {
                    Stock stock = new Stock();
                    DataRow row = stock.getCurrent(textBarCode.Text);
                    // int total = Convert.ToInt32(row["totalqty"].ToString());


                    // minus value after saleqty
                    // _qunatity = (total - Convert.ToInt32(txtSaleQty.Text));


                    // pos.updateQtyForPos(textBarCode.Text,_qunatity);
                    //_qunatity = 0;
                    // dataGridView1.DataSource = null;
                    // dataGridView1.DataSource = pos.getDataPOS().Tables[0];

                    //  pos.updateQty(Convert.ToInt32(textBarCode.Text), Convert.ToInt32(new_qty));
                    //txtAvailableQty.Text = total.ToString();
                    txtUnitPrice.Text = row["sellingprice"].ToString();
                    txtItemName.Text = pos.getItemName(textBarCode.Text);
                    //txtItemName.Text = row["productname"].ToString();

                    if (txtSaleQty.Text != "")
                    {
                        int saleQty = Convert.ToInt32(txtSaleQty.Text);
                        double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
                        double _total = saleQty * unitPrice;
                        txtTotalAmount.Text = _total.ToString();
                        if (!txtAvailableQty.Text.ToString().Equals("0"))
                        {
                            addToCart();
                        }
                        else
                        {
                            MessageBox.Show("Quantity Not Available ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        }
                        textBarCode.Text = "";
                        this.ActiveControl = textBarCode;
                    }
                    else
                        MessageBox.Show("Kindly specify quantity first ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
            }
            else {

                // MessageBox.Show("Sorry invalid Barcode, Try Again");
            }
        }

        private void txtTotal_Leave_1(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (!(txtTotal.Text == "" || Convert.ToDouble(txtTotal.Text) < 0))
            {
                double payment_total = Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtGrandTotal.Text);

                if (payment_total > -1)
                {
                    txtPaymentDue.Text = payment_total.ToString();
                }
                Customer c = new Customer();
                if (txtCustomerId.Text != "")
                {

                   if (!c.checkContactNumber(Convert.ToInt64(txtCustomerId.Text)))
                    {
                        
                        DialogResult dialogResult = MessageBox.Show("Do you want to add in Balance?", "Balance Account", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                        if (dialogResult == DialogResult.Yes  )
                        {
                            if(!flag)
                            txtNewBalance.Text = (Convert.ToDouble(txtNewBalance.Text)+payment_total).ToString();
                          else
                                txtNewBalance.Text = (Convert.ToDouble(txtBalnace.Text) + payment_total).ToString();

                        }
                        else if (dialogResult == DialogResult.No)
                        {

                            MessageBox.Show("Sorry! Please Enter Amount Greater or Equal then Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                            //do something else
                        }

                        //if (payment_total < -1)
                        //{
                        //    txtPaymentDue.Text = payment_total.ToString();
                        //    txtNewBalance.Text = (Convert.ToDouble(txtNewBalance.Text) + Convert.ToDouble(payment_total)).ToString();

                        //}
                    }
                    else
                        MessageBox.Show("Sorry! Please Enter Amount Greater or Equal then Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        
        string customerCity;
        string customerState;


        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            Customer c = new Customer();
            Int64 checkLong;

            if (txtCustomerId.Text!= "" || !Int64.TryParse(txtCustomerId.Text, out checkLong))
            { 
            if (!c.checkContactNumber(Convert.ToInt64(txtCustomerId.Text)))
            {
                DataSet ds = new DataSet();
                ds = c.getCustomerData(Convert.ToInt64(txtCustomerId.Text));

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    txtCustomerName.ReadOnly = true;
                    txtCustomerName.Text = (row["customerFirstName"].ToString()+" " + row["customerLastName"].ToString());
                    txtBalnace.Text = row["Balance"].ToString();
                    customerCity = row["customerCity"].ToString();
                    customerState = row["Address"].ToString();

                }

            }
            }
        }

        private void txtTotal_TextChanged_1(object sender, EventArgs e)
        {

        }
        // Button INCLUDE BALANCE
        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                if (Convert.ToDouble(txtBalnace.Text) < 0)
                {

                    txtGrandTotal.Text = (_grandtotal + Convert.ToDouble(txtBalnace.Text.Remove(0, 1))).ToString();
                    txtNewBalance.Text = "0";
                }
                else
                {
                    if (_grandtotal >= Convert.ToDouble(txtBalnace.Text))
                    {
                        txtGrandTotal.Text = (_grandtotal - Convert.ToDouble(txtBalnace.Text)).ToString();
                        txtNewBalance.Text = "0";

                    }
                    else
                    {
                        txtNewBalance.Text = (Convert.ToDouble(txtBalnace.Text) - _grandtotal).ToString();
                        txtGrandTotal.Text = "0";
                    }
                }
            }
            else
            {
                flag = true;
                txtGrandTotal.Text = _grandtotal.ToString();
                txtNewBalance.Text = txtBalnace.Text;

                }

            
        }

        private void grdCart_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdCart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (grdCart.Columns[e.ColumnIndex].Name == "Qty" )
            {
                

                int selectedrowindex = grdCart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grdCart.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Qty"].Value);
                string barcode = Convert.ToString(selectedRow.Cells["BarCode"].Value);

               // int qtyDB = Convert.ToInt32(pos.getQty(barcode));

                //pos.updateQtyForPos(barcode.ToString(), (qtyDB + Convert.ToInt32(a)));
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Cells[0].Value.ToString().Equals(barcode.ToString()))
                    {
                        row1.Cells[3].Value = (Convert.ToInt32(row1.Cells[3].Value.ToString()) + Convert.ToInt32(a)).ToString();
                      /*  if (row1.Cells[3].Value.ToString().Equals("0"))
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            visi = true;
                            currencyManager1.SuspendBinding();
                            row1.Visible = false;
                            currencyManager1.ResumeBinding();
                        }
                        else if (visi)
                        {
                            visi = false;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

                            currencyManager1.SuspendBinding();
                            row1.Visible = true;
                            currencyManager1.ResumeBinding();

                        }*/

                        dataGridView1.Refresh();
                        break;
                    }
                }
            }

            else if(grdCart.Columns[e.ColumnIndex].Name == "sellingprice")
            {
                int selectedrowindex = grdCart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grdCart.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["sellingprice"].Value);

            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInvoiceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSaleQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtNewBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBalnace_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPaymentDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSearchbyCode_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if(txtSearchByItemCode.Text!="")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView2.Rows.Clear();

                for(int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString().StartsWith(txtSearchByItemCode.Text.ToString()))
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[temp].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        dataGridView2.Rows[temp].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        dataGridView2.Rows[temp].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        dataGridView2.Rows[temp].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        dataGridView2.Rows[temp].Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        temp++;
                    }
                }
            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string a = row.Cells[0].Value.ToString();
                string b = row.Cells[1].Value.ToString();
                string c = row.Cells[2].Value.ToString();




                txtAvailableQty.Text = row.Cells[3].Value.ToString();
                if(txtAvailableQty.Text == "0")
                {
                    txtSaleQty.Text = "0";
                }
                textUnit.Text = row.Cells[4].Value.ToString();
                if (!row.Cells[3].Value.ToString().Equals("0"))
                {
                    row.Cells[3].Value = (Convert.ToInt32(row.Cells[3].Value.ToString()) - 1).ToString();
                    ChangeValueInMainGrid(row.Cells[0].Value.ToString());
                }
                /*if (row.Cells[3].Value.ToString().Equals("0"))
                {
                    visi = true;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView2.DataSource];

                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else if (visi)
                {
                    visi = false;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView2.DataSource];

                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();

                }*/
                dataGridView2.Refresh();



                txtSearchByItemCode.Text = a;
                txtItemName.Text = b;
                // textBarCode.Text = txtSearchByItemCode.Text;
                txtUnitPrice.Text = c;
            }
        }

        private void BtnSearchbyName_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (txtSearchByItemName.Text != "")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView2.Rows.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().StartsWith(txtSearchByItemName.Text.ToString()))
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[temp].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        dataGridView2.Rows[temp].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        dataGridView2.Rows[temp].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        dataGridView2.Rows[temp].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        dataGridView2.Rows[temp].Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        temp++;
                    }
                }
            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
        }

        void ChangeValueInMainGrid(string barcode)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value.ToString() == barcode)
                    row.Cells[3].Value = (Convert.ToInt32(row.Cells[3].Value.ToString()) - 1).ToString();
            }
        }
    }
    }

