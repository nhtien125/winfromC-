using System.Data;
using System.Data.SqlClient;
using System.Text;

using iTextSharp.text;
using iTextSharp.text.pdf;
using ClosedXML.Excel;




namespace WinFormsApp1.Functions
{
    internal class Functions
    {
        public static SqlConnection con = new SqlConnection();
        public static string id;
        public static string role;
        public static SqlCommand cmd2;
        

        public static void Connect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = Properties.Settings.Default.sqlCon;
                con.Open();
            }
            else
                return;
        }

        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }

        public static void Login(String username, String pass)
        {
            if (username == "" || pass == "")
            {
                Form1.gui.loginStatus_setStatus("Nhập đầy đủ thông tin", true);
                return;

            }
            else
            {
                Connect();
                cmd2 = new SqlCommand();
                String sql2 = "select * from dbo.tbl_Account where Username = '" + username.Trim().ToUpper() + "'";
                SqlDataReader reader = RunSqlwithreturn(sql2, cmd2);
                if (reader.Read())
                {
                    id = reader.GetString(0);
                    String mk = reader.GetString(2);
                    role = reader.GetString(3);
                    if (mk != pass)
                    {
                        reader.Close();
                        Form1.gui.loginStatus_setStatus("Sai mat khau", true);
                        return;
                    }
                    MessageBox.Show("đăng nhập ok");
                    reader.Close();
                    String name = Welcome();
                    adminform form2 = new adminform();
                    adminform.guiAdmin.setWelcome(name);
                    adminform.setCurrentID(id);
                    Form1.gui.Hide();                    
                    form2.ShowDialog();                    
                    Form1.gui.Dispose();
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    Form1.gui.loginStatus_setStatus("Không tồn tại tài khoản", true);
                    return;
                }
            }
        }

        //Function để dùng parametter

        public static void RunSQL(string sql, SqlCommand cmd2)
        {
            Connect();

            cmd2.Connection = con; //Gán kết nối
            cmd2.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd2.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd2.Dispose();//Giải phóng bộ nhớ
            cmd2 = null;
        }

        public static SqlDataReader RunSqlwithreturn(string sql, SqlCommand cmd)
        {
            Connect();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
            return reader;

        }

        public static object RunSqlWithScalar(String sql, SqlCommand cmd)
        {
            Connect();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            var text = cmd.ExecuteScalar();
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
            return text;
        }

        public static String getID()
        {
            return id;
        }

        public static void setID(String value)
        {
            id = value;
        }

        public static String Welcome()
        {
            Connect();
            String id = getID();
            cmd2 = new SqlCommand();
            String sql = "select * from dbo.tbl_nhanvien where MaNV = '" + id + "'";
            SqlDataReader reader = RunSqlwithreturn(sql, cmd2);
            if (reader.Read())
            {
                String name = "";
                name = reader.GetString(1);
                reader.Close();
                return name;
            }
            else
                reader.Close ();
                adminform.guiAdmin.setWelcome("error");
            return "";
        }

        public static String dateTime()
        {
            DateTime t = DateTime.Now;
            String day = t.Day.ToString();
            String month = t.Month.ToString();
            String year = t.Year.ToString();
            String hour = t.Hour.ToString();
            String minute = t.Minute.ToString();
            String second = t.Second.ToString();
            String date = day + "/" + month + "/" + year + "     " + hour + ".h " + minute + ".m " + second + ".s ";
            return date;
        }

        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = con;
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        public static bool CheckKey(string sql)
        {
            Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static bool checkNull(string sql)
        {
            Connect();
            cmd2.Connection = con; //Gán kết nối
            cmd2.CommandText = sql; //Gán lệnh SQL
            var c = RunSqlWithScalar(sql, cmd2);
            if (c == null)
            {
                return true;
            }
            return false;
        }

        public static void getSelectedRows(DataGridView data, int cells, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = data.Rows[index];
            setID(selectedRow.Cells[cells].Value.ToString());
        }

        public static Byte[] getByteImage(PictureBox pic)
        {
            MemoryStream stream = new MemoryStream();
            pic.Image.Save(stream, pic.Image.RawFormat);
            byte[] data = stream.ToArray();
            if (data != null && data.Length > 0)
            {
                return data;
            }
            return BitConverter.GetBytes(0);
        }

        public static void createPDF(String sql, String strHeader)
        {          
            string fileToRead = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\font\\arial.ttf";
            var fileToRead2 = Encoding.UTF8.GetBytes(fileToRead);
            String file = Encoding.Default.GetString(fileToRead2);
            BaseFont font = BaseFont.CreateFont(file, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            var dataTable = GetDataToTable(sql);
            Document document = new Document(PageSize.A4.Rotate(),15,15,15,15);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDFfiles|*.pdf";
            sfd.Title = "Save an PDF File";
            sfd.FileName = "Danh sách";
                    
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String a = sfd.FileName;
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(a, FileMode.Create));
                document.Open();
                PdfPTable table = new PdfPTable(dataTable.Columns.Count);
                table.WidthPercentage = 100;               
                iTextSharp.text.Font fontCol = new iTextSharp.text.Font(font, 14f,1,BaseColor.WHITE);
                iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(font, 20f, 1, BaseColor.BLUE);
                Paragraph para = new Paragraph();
                para.Alignment = Element.ALIGN_CENTER;
                para.Add(new Chunk(strHeader, fontHeader));
                document.Add(para);
                document.Add(new Chunk("\n",fontHeader));
                //Set columns names in the pdf file
                for (int k = 0; k < dataTable.Columns.Count; k++)                
                {
                    
                    PdfPCell cell = new PdfPCell();                    
                    cell.BackgroundColor = BaseColor.GRAY;                   
                    cell.AddElement(new Chunk(dataTable.Columns[k].ToString().ToUpper(),fontCol));              
                    table.AddCell(cell);
                }
                //Add values of DataTable in pdf file
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));  
                        table.AddCell(cell);
                    }
                }
                document.Add(table);
                document.Close();
                writer.Close();
            }
        }

        public static void ExportToExcel(String sql)
        {
            //String sql = "Select * From dbo.tbl_nhanvien";
            var table = GetDataToTable(sql);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files|*.xlsx";
            sfd.Title = "Save an Excel File";
            sfd.FileName = "Danh sách";
            using (XLWorkbook wb = new XLWorkbook())
            {
                //var ws = wb.Worksheets.Add();
                //ws.Columns().AdjustToContents();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var ws = wb.Worksheets.Add(table,"DSNV");
                    ws.Style = XLWorkbook.DefaultStyle;
                    ws.Rows().AdjustToContents();                    
                    ws.Columns().Width = 13;
                    ws.Column(2).Width = 16;
                    var row1 = ws.Row(1);              
                    row1.Style.Font.SetFontSize(13);
                    row1.Style.Font.SetVerticalAlignment(XLFontVerticalTextAlignmentValues.Baseline);
                    /*
                    int numRow = 2;
                    for (int p = 2; p <= DSNV2.Columns.Count; p++)
                    {
                        ws.Cell(1, 1).Value = "Stt";
                        ws.Cell(1, p).Value = DSNV2.Columns[p - 2].ColumnName;
                    }
                    ws.Rows().AdjustToContents();
                    ws.Columns().Width = 13;
                    var row1 = ws.Row(1);

                    row1.Style.Font.SetFontSize(13);
                    row1.Style.Font.SetFontColor(XLColor.Red);
                    row1.Style.Font.SetVerticalAlignment(XLFontVerticalTextAlignmentValues.Baseline);                  
                    foreach (DataRow row in DSNV2.Rows)
                    {
                        int a = 1;
                        ws.Cell(2, 1).Value = a;
                        ws.Cell(numRow, 2).Value = (String)row[0];
                        ws.Cell(numRow, 3).Value = (String)row[1];
                        ws.Cell(numRow, 4).Value = (String)row[2];
                        ws.Cell(numRow, 5).Value = (String)row[3];
                        ws.Cell(numRow, 6).Value = (String)row[4];
                        ws.Cell(numRow, 7).Value = (String)row[5];
                        ws.Cell(numRow, 8).Value = (String)row[6];
                        ws.Cell(numRow, 9).Value = (String)row[7];
                        numRow++;
                        a++;

                    }*/
                    try
                    {
                        wb.SaveAs(sfd.FileName);
                    } catch (InvalidCastException e)
                    { MessageBox.Show(e.Message);
                        return;
                    }
                    wb.Dispose();

                }
            }
        }

        public static string getRoles()
        {
            return role;
        }

        public static String connverter(DateTime dateTime)
        {
            String a = dateTime.DayOfWeek.ToString();
            String b = "";
            switch (a)
            {
                case "Monday":
                    b = "Thứ 2";
                    break;
                case "Tuesday":
                    b = "Thứ 3";
                    break;
                case "Wednesday":
                    b = "Thứ 4";
                    break;
                case "Thursday":
                    b = "Thứ 5";
                    break;
                case "Friday":
                    b = "Thứ 6";
                    break;
                case "Saturday":
                    b = "Thứ Bảy";
                    break;
                case "Sunday":
                    b = "Chủ nhật";
                    break;
            }
            return b;
        }

        public static int check2(string sql, SqlCommand cmd)
        {
            Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            int i = table.Rows.Count;
                return i;
            
        }

    }    
}
