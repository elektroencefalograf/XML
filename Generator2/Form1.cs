using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Generator2
{
    public partial class Form1 : Form
    {
       public static string locConnection = "User Id = s95522; Password = 9584626; Data Source = 217.173.198.135:1522/orcltp.iaii.local;";
       public static OracleConnection connection = new OracleConnection(locConnection);
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Nauczyciele");
            comboBox1.Items.Add("Oceny");
            comboBox1.Items.Add("Klasy");
            comboBox1.Items.Add("Uczniowie");
            comboBox1.Items.Add("Obecnosc");
            comboBox1.Items.Add("Typ Oceny");
            comboBox1.Items.Add("Sale");
            comboBox1.Items.Add("Sale zajęciowe");
            comboBox1.Items.Add("Uczy");
            comboBox1.Items.Add("Przedmioty");
            comboBox1.Text = "Nauczyciele";
           

        }
        public static void exportNaucz()
        { 
           
            var nauczyciele = "";
            DataSet ds = new DataSet("Nauczyciele");
            string table = "nauczyciele";
            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Nauczyciel");
            da.Fill(ds);

            nauczyciele += ds.GetXml();
            connection.Close();
           

            File.WriteAllText("D://nauczyciele.xml", nauczyciele);
        }
        public static void exportUczni()
        {
            
            var Uczniowie = "";
            DataSet ds = new DataSet("Uczniowie");
            string table = "Uczniowie";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Uczen");
            da.Fill(ds);


            Uczniowie += ds.GetXml();

            connection.Close();
            
            File.WriteAllText("D://uczniowie.xml", Uczniowie);
        }
        public static void exportUczy()
        {
           
            var Uczy = "";
            DataSet ds = new DataSet("Uczy");
            string table = "Uczy";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Uczy");
            da.Fill(ds);


            Uczy += ds.GetXml();

            connection.Close();
            
            File.WriteAllText("D://uczy.xml", Uczy);
        }
        public static void exportKlasy()
        {
            
            var klasy = "";
            DataSet ds = new DataSet("Klasy");
            string table = "klasy";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Klasa");
           
            da.Fill(ds);
           

            klasy += ds.GetXml();

            connection.Close();
            
            File.WriteAllText("D://Klasy.xml", klasy);
        }
        public static void exportOceny()
        {
           
            var Oceny = "";
            DataSet ds = new DataSet("Oceny");
            string table = "Oceny";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Ocena");
            da.Fill(ds);


            Oceny += ds.GetXml();
            connection.Close();
            
            File.WriteAllText("D://Oceny.xml", Oceny);
        }
        public static void exportPrzedmioty()
        {
            
            var Przedmioty = "";
            DataSet ds = new DataSet("Przedmioty");
            string table = "Przedmioty";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Przedmiot");
            da.Fill(ds);


            Przedmioty += ds.GetXml();


            connection.Close();
            
            File.WriteAllText("D://przedmioty.xml", Przedmioty);
        }
        public static void exportSale()
        {
           
            var sala = "";
            DataSet ds = new DataSet("Sale");
            string table = "Sala";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Sala");
            da.Fill(ds);


            sala += ds.GetXml();
            connection.Close();
           

            File.WriteAllText("D://sala.xml", sala);
        }
        public static void exportSale_zaj()
        {
           
            var sala_zajeciowa = "";
            DataSet ds = new DataSet("sale_zajeciowe");
            string table = "Sala_zajeciowa";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Sala_zajeciowa");
            da.Fill(ds);


            sala_zajeciowa += ds.GetXml();

            connection.Close();
            
            File.WriteAllText("D://sala_zajeciowa.xml", sala_zajeciowa);
        }
        public static void exportObecnosc()
        {
            
            var Obecnosc = "";
            DataSet ds = new DataSet("Obecnosci");
            string table = "Obecność";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Obecnosc");
            da.Fill(ds);


            Obecnosc += ds.GetXml();


            connection.Close();
            
            File.WriteAllText("D://obecnosc.xml", Obecnosc);
        }
        public static void exportTyp_oceny()
        {
           
            var typ_oceny = "";
            DataSet ds = new DataSet("Typy_oceny");
            string table = "typ_oceny";

            connection.Open();
            var query = "SELECT * FROM " + table;

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "Typ_oceny");
            da.Fill(ds);


            typ_oceny += ds.GetXml();


            connection.Close();
          
            File.WriteAllText("D://typ_oceny.xml", typ_oceny);
        }


        public static void importNaucz()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            int nauczyciele_id = 0;
            string Imie = "";
            string Nazwisko = "";
            string Plec = "";
            int klasy_id = 0;

            xmlFile = XmlReader.Create(@"D:\nauczyciele.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                nauczyciele_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0]);
                Imie = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                Nazwisko = dataSet.Tables[0].Rows[i].ItemArray[2].ToString();
                klasy_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[3]);
                Plec = dataSet.Tables[0].Rows[i].ItemArray[4].ToString();

                sql = "insert into nauczyciele(nauczyciele_ID,imie,nazwisko,klasy_klasy_id,plec)" +
                    " VALUES(nauczyciele_seq.nextval" + ",'" + Imie + "','" + Nazwisko + "','" + klasy_id + "','" + Plec + "')";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine(i);
            }
            connection.Close();
            
        }
        public static void importUczni()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;

            string Imie;
            string Nazwisko;
            string data;
            string miejsce_uro;
            string miejsce_zam;
            string plec;
            int srednia;
            int uczniowie_id;
            int klasy_id;
           
            xmlFile = XmlReader.Create(@"D:\uczniowie.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
               
                Imie = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                Nazwisko = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                data = dataSet.Tables[0].Rows[i].ItemArray[2].ToString().Replace("T00:00:00+01:00", "");
                miejsce_uro = dataSet.Tables[0].Rows[i].ItemArray[3].ToString();
                miejsce_zam = dataSet.Tables[0].Rows[i].ItemArray[4].ToString();
                plec = dataSet.Tables[0].Rows[i].ItemArray[5].ToString();
                srednia = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[6]);
                uczniowie_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[7]);
                klasy_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[8]);

                sql = "insert into uczniowie(imie,nazwisko,data_urodzenia,miejsce_urodzenia,miejsce_zamieszkania,plec,srednia,uczniowie_id,klasy_klasy_id)" +
                    " VALUES('" + Imie + "','" + Nazwisko + "',TO_DATE('" + data + "','YYYY-MM-DD'),'" + miejsce_uro + "','" + miejsce_zam + "','" + plec + "','"+ srednia + "',uczniowie_seq.nextval,'" + klasy_id +"')";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                
            }
            connection.Close();
            
        }
        public static void importUczy()
        {
            OracleCommand command;
           
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            int nauczyciele_id;
            int przedmioty_id;
       

            xmlFile = XmlReader.Create(@"D:\uczy.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                nauczyciele_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0]);
                przedmioty_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[1]);
               

                sql = "INSERT INTO uczy(przedmiony_przedmiony_id,nauczyciele_nauczyciele_id,uczy_id)" +
                      " VALUES('"+ nauczyciele_id +"','"+ przedmioty_id +"',uczy_seq.nextval)";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                
            }
            connection.Close();
            
        }
        public static void importKlasy()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            
            string nazwa = "";
            string specjalnosc = "";
            string data = "";

            xmlFile = XmlReader.Create(@"D:\klasy.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                nazwa = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                specjalnosc = dataSet.Tables[0].Rows[i].ItemArray[2].ToString();
                data = dataSet.Tables[0].Rows[i].ItemArray[3].ToString().Replace("T00:00:00+01:00", "");
           


                sql = "INSERT INTO klasy(klasy_id, nazwa, specjalnosc, data_rozpoczecia)" +
                     " VALUES(klasy_seq.nextval, '" + nazwa + "','" + specjalnosc +"',TO_DATE('"+ data +"','YYYY-MM-DD'))";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                
            }
            connection.Close();
            
        }
        public static void importOceny()
        {
            OracleCommand command;

            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            int ocena = 0;
            string data = "";
            int nauczyciele_id = 0;
            int przedmioty_id = 0;
            int typ_oceny_id = 0;
            int uczniowie_id = 0;


            xmlFile = XmlReader.Create(@"D:\oceny.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                ocena = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0]);
                data = dataSet.Tables[0].Rows[i].ItemArray[1].ToString().Replace("T00:00:00+01:00","");
                nauczyciele_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[2]);
                przedmioty_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[3]);
                typ_oceny_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[4]);
                uczniowie_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[5]);


                sql = "INSERT INTO oceny(ocena, data_wystawienia, nauczyciele_nauczyciele_id, przedmiony_przedmiony_id, typ_oceny_typ_oceny_id, uczniowie_uczniowie_id, id_oceny)" +
                      " VALUES(" + ocena + ", TO_DATE('" + data + "','YYYY-MM-DD'), " + nauczyciele_id + ", " + przedmioty_id + ", " + typ_oceny_id + ", " + uczniowie_id + ", oceny_seq.nextval)";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
               
            }
            connection.Close();

        }
        public static void importPrzedmioty()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            
            string nazwa = "";
           

            xmlFile = XmlReader.Create(@"D:\przedmioty.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
               
                nazwa = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
               

                sql = "insert into przedmioty(nazwa,przedmioty_id)" +
                    "VALUES('" + nazwa + "', przedmioty_seq.nextval)";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine(i);
            }
            connection.Close();
            
        }
        public static void importSale()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            int numer_sali;
            int nauczyciele_id;

            xmlFile = XmlReader.Create(@"D:\sala.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                numer_sali = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0]);
                nauczyciele_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[2]);


                sql = "insert into sala(numer_sali,sala_id,nauczyciele_nauczyciele_id)" +
                    " VALUES(" + numer_sali + ",sale_seq.nextval,'" + nauczyciele_id + "')";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
            
        }
        public static void importSale_zaj()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            int uczniowie_id = 0;
            int sale_id = 0;
            xmlFile = XmlReader.Create(@"D:\sala_zajeciowa.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                uczniowie_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0]);
                sale_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[1]);


                sql = "insert into sala_zajeciowa(uczniowie_uczniowie_id,sala_sala_id,sala_zj_id)" +
                    " VALUES(" + uczniowie_id + ",'" + sale_id +"',sale_zj_seq.nextval)";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
               
            }
            connection.Close();
            
        }
        public static void importObecnosc()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            string obecnosc = "";
            int uczniowie_id = 0;
           
            xmlFile = XmlReader.Create(@"D:\obecnosc.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {
                obecnosc = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                uczniowie_id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[1]);
               



                sql = "insert into obecność(obecność,uczniowie_uczniowie_id,id_obecnosc)" +
                    " VALUES('" + obecnosc + "','" + uczniowie_id + "',obecnosc_seq.nextval)";
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                
            }
            connection.Close();
           
        }
        public static void importTyp_Oceny()
        {
            OracleCommand command;
            
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            
            string Typ_Oceny = "";
            

            xmlFile = XmlReader.Create(@"D:\typ_oceny.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            connection.Open();
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
            {

                Typ_Oceny = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
               

                sql = "INSERT INTO typ_oceny(typ_oceny,typ_oceny_id)" +
                       " VALUES('" + Typ_Oceny + "',typ_seq.nextval)"; 
                command = new OracleCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine(i);
            }
            connection.Close();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Nauczyciele")
                {
                    label1.Text = "";
                    exportNaucz();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Oceny")
                {
                    label1.Text = "";
                    exportOceny();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Przedmioty")
                {
                    label1.Text = "";
                    exportPrzedmioty();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Sale")
                {
                    label1.Text = "";
                    exportSale();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Sale zajęciowe")
                {
                    label1.Text = "";
                    exportSale_zaj();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Uczy")
                {
                    label1.Text = "";
                    exportUczy();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Uczniowie")
                {
                    label1.Text = "";
                    exportUczni();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Typ Oceny")
                {
                    label1.Text = "";
                    exportTyp_oceny();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Obecnosc")
                {
                    label1.Text = "";
                    exportObecnosc();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Klasy")
                {
                    label1.Text = "";
                    exportKlasy();
                    label1.Text = "done";
                }
            }
            catch(OracleException ex)
            {
                if (ex.ErrorCode.ToString().Contains("ORA-00942"))
                {
                    MessageBox.Show("Tabela nie istnieje");
                }
            }
            finally
            {
                connection.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Nauczyciele")
                {
                    label1.Text = "";
                    importNaucz();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Oceny")
                {
                    label1.Text = "";
                    importOceny();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Przedmioty")
                {
                    label1.Text = "";
                    importPrzedmioty();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Sale")
                {
                    label1.Text = "";
                    importSale();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Sale zajęciowe")
                {
                    label1.Text = "";
                    importSale_zaj();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Uczy")
                {
                    label1.Text = "";
                    importUczy();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Uczniowie")
                {
                    label1.Text = "";
                    importUczni();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Typ Oceny")
                {
                    label1.Text = "";
                    importTyp_Oceny();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Obecnosc")
                {
                    label1.Text = "";
                    importObecnosc();
                    label1.Text = "done";
                }
                else if (comboBox1.Text == "Klasy")
                {
                    label1.Text = "";
                    importKlasy();
                    label1.Text = "done";
                }
            }
            catch (OracleException ex)
            {
                if (ex.ErrorCode.ToString().Contains("ORA-00942"))
                {
                    MessageBox.Show("Tabela nieistnieje");
                }
                else
                {
                    MessageBox.Show("Dziwne u mnie działa");
                }
               
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
