using System.Data.SqlClient;

namespace NotDefterim
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            con = new SqlConnection("server=.; database=NotDefterimDb; trusted_connection=true");
            con.Open();
            InitializeComponent();
            string cmdText = "SELECT Id,Baslik,Icerik FROM Notlar";
            var cmd = new SqlCommand(cmdText, con);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Not not = new Not();
                //not.Id = (int)dr[0];
                not.Id = dr.GetInt32(0);
                not.Baslik = dr.GetString(1);
                not.Icerik = dr[2] == DBNull.Value ? null : dr.GetString(2);
                lstBasliklar.Items.Add(not);
            }
            dr.Close();
            Guncelle();
        }

        private void lstBasliklar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBasliklar.SelectedItem != null)
            {
                Not secili = (Not)lstBasliklar.SelectedItem;
                txtIcerik.Text = secili.Icerik;
                txtBaslýk.Text = secili.Baslik;
            }
            Guncelle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstBasliklar.SelectedItem != null)
            {
                Not secili = (Not)lstBasliklar.SelectedItem;
                SqlCommand cmd = new SqlCommand("update Notlar set Baslik=@p1,Icerik=@p2 where Id=@p3", con);
                cmd.Parameters.AddWithValue("@p1", txtBaslýk.Text);
                cmd.Parameters.AddWithValue("@p2", txtIcerik.Text);
                cmd.Parameters.AddWithValue("@p3", secili.Id);
                cmd.ExecuteNonQuery();
                secili.Baslik = txtBaslýk.Text;
                secili.Icerik = txtIcerik.Text;
                lstBasliklar.DisplayMember = null;
                lstBasliklar.DisplayMember = "Baslik";
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Not yeni = new Not() { Baslik = "Yeni Not" };
            var cmd = new SqlCommand("insert into Notlar(Baslik,Icerik) values(@p1,'');select scope_identity()", con);//select scope_identity()  bu komut cmd deki komut satýr sonuna eklenerek bulunur.bu satýr tek bir deðer verir.decimal döndürür.
            cmd.Parameters.AddWithValue("@p1", yeni.Baslik);
            decimal id = (decimal)cmd.ExecuteScalar();
            yeni.Id = (int)id;   //sql tarafýndan verilen Id= bunu veren komut= select scope_identity()
            lstBasliklar.Items.Add(yeni);
            lstBasliklar.SelectedItem = yeni;
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstBasliklar.SelectedItem != null)
            {
                int index = lstBasliklar.SelectedIndex;
                Not secili = (Not)lstBasliklar.SelectedItem;
                var cmd = new SqlCommand("delete from Notlar where Id=@p1", con);
                cmd.Parameters.AddWithValue("@p1", secili.Id);
                cmd.ExecuteNonQuery();
                lstBasliklar.Items.Remove(secili);
                lstBasliklar.SelectedIndex = Math.Min(index,lstBasliklar.Items.Count-1);
                Guncelle();
            }
        }
        void Guncelle()
        {
            if (lstBasliklar.SelectedItem==null)
            {
                pnlDuzenle.Hide();
            }
            else
            {
                pnlDuzenle.Show();
            }
        }
    }
}